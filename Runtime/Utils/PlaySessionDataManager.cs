using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.Networking;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;

namespace PlaytestingTool
{
    public class PlaySessionDataManager
    {
        private const string V = "\result.zip";

        /// <summary>
        /// <para>Saves session data class locally in specified folder.</para>
        /// <para>Data will be put in folder with timestamp of play session.</para>
        /// <para>any other data from that play session will be saved in the same folder.</para>
        /// <list type="bullet">enpoint is specified in the Tools Settings <c>Settings.FOLDERPATH</c></list>
        /// </summary>
        /// <param name="sessionData">The Session data you wish to save locally, it will be converted to Json</param>
        public static void SavePlayerDatJson(SessionData sessionData)
        {
            string folderName = $"{DateTime.Now:dd-MM-yy} PlaySession {sessionData.sessionName.Substring(0, 4)}";
            Debug.Log($"DATA CREATED LOCALLY</a>");

            //FileStream fs = new FileStream($"./Assets/SessionData/{folderName}/{fileName}.dat", FileMode.Create);
            //BinaryFormatter formatter = new BinaryFormatter();
            ////Binary 
            //try
            //{
            //    formatter.Serialize(fs, playerData);
            //} 
            //catch (Exception e)
            //{
            //    Debug.LogError(e.Message);

            //}
            //finally
            //{
            //    fs.Close();
            //}

            //JSON
            try
            {
                string json = JsonUtility.ToJson(sessionData, true);
                string path = $"{Settings.FOLDERPATH}/{folderName}/";
                string file = $"SessionData {sessionData.objectName}.json";

                Debug.Log(Settings.FOLDERPATH);

                if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                //while (File.Exists(path + file))
                //    file = $"SessionData {sessionData.objectName}_{fileCount++}.json";

                File.WriteAllText(path + file, json);

            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }

        /// <summary>
        /// <para>Load Data from Local repository</para>
        /// <para>Folder the data is loaded from is specified in the Tools Settings <c>Settings.FOLDERPATH</c></para>
        /// </summary>
        /// <param name="fileName">name of the file that will be uploaded</param>
        /// <returns>Deserialized SessionData class from local saved Json</returns>
        public static SessionData LoadPlayerDataJson(string fileName)
        {
            try
            {
                string path = $"{Settings.FOLDERPATH}/";

                string json = File.ReadAllText(path + fileName);
                SessionData playerdata = new SessionData();
                JsonUtility.FromJsonOverwrite(json, playerdata);
                return playerdata;
            }
            catch (Exception e)
            {
                Debug.LogWarning($"No Data {e.Message}");
                return null;
            }
        }

        /// <summary>
        /// <para>Data will be uploaded in JSON form to the specified endpoint.</para>
        /// <list type="bullet">enpoint is specified in the Tools Settings <c>Settings.FOLDERPATH</c></list>
        /// </summary>
        /// <param name="sessionData">The Session data you wish to upload, it will be converted to Json</param>
        public static void UploadSessionData(SessionData sessionData)
        {
            try
            {
                string json = JsonUtility.ToJson(sessionData, true);
                string collectionName = $"{DateTime.Now:dd-MM-yy} PlaySession {sessionData.sessionName.Substring(0, 4)}";

                WebClient myWebClient = new WebClient();
                myWebClient.Encoding = System.Text.Encoding.UTF8;
                myWebClient.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8");
                myWebClient.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + Settings.AUTHTOKEN);

                string responseArray = myWebClient.UploadString($"{Settings.WEBENDPOINT}/{collectionName}", "POST", json);

                Debug.Log($"Server Response: {responseArray}");
            }
            catch (Exception e)
            {
                Debug.LogError("Unable to connect");
                Debug.LogError(e.Message);
            }

        }

        /// <summary>
        /// Pull data from the enpoint is specified in the Tools Settings <c>Settings.PULLREQUESTLINK</c></list> 
        /// </summary>
        public static void DownloadData()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Settings.PULLREQUESTLINK);
            request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + Settings.AUTHTOKEN);
            request.Method = "GET";
            String test = String.Empty;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                test = reader.ReadLine();
                reader.Close();
                dataStream.Close();
            }
            
            Debug.Log("Began Downloading Data");

            string pattern = @"(?={\""_id"":"")";
            string[] splitTest = Regex.Split(test, pattern);

            //Debug.Log(splitTest.Length);

            int MissingJsonFiles = 0;

            for (int i = 0; i < splitTest.Length; i++)
            {
                string item = splitTest[i];
                //Debug.Log(item);

                SessionData sessionData = new SessionData();

                try
                {
                    // Validate JSON
                    if (!(item.StartsWith("{") && item.EndsWith("}")))
                    {
                        if (item.EndsWith(","))
                        {
                            item = item.Remove(item.Length - 1, 1);
                        }

                        else if (item.EndsWith("],["))
                        {
                            item = item.Remove(item.Length - 3, 3);
                        }

                        else if (item.EndsWith("]]"))
                        {
                            item = item.Remove(item.Length - 2, 2);
                        }

                        else if (item.EndsWith("[["))
                        {
                            continue;
                        }
                    }

                    JsonUtility.FromJsonOverwrite(item, sessionData);

                }
                catch (Exception e)
                {
                    MissingJsonFiles++;
                    Debug.LogError( $"Not Valid JSON \n {item} \n Error {e}" );
                }

                try
                {
                    string folderName = $"{DateTime.Now:dd-MM-yy} PlaySession {sessionData.sessionName.Substring(0, 4)}";

                    string path = $"{Settings.FOLDERPATH}/{folderName}/";
                    string file = $"SessionData {sessionData.objectName}.json";

                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                    File.WriteAllText(path + file, item);

                    //while (File.Exists(path + file))
                    //    file = $"SessionData {sessionData.objectName}_{fileCount++}.json";
                }
                catch (Exception e)
                {
                    Debug.LogError(e.Message);
                }

            }

            Debug.Log($"Successfuly Downloaded JSON files from DATABASE \n {MissingJsonFiles} files failed");
        }

        public static void ConvertToCSV(string fileName)
        {
            SessionData sessionData = LoadPlayerDataJson(fileName);
            string StartingRowLine = "Time";

            Debug.Log(sessionData.trackedProgressions.Count);

            try
            {
                string csvFileName = $"SessionData {sessionData.objectName}.csv";
                string path = $"{Settings.FOLDERPATH}/";

                if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                TextWriter textWriter = new StreamWriter(path + csvFileName, false);

                List<String> CSVLine = new List<string>();
                string firstLine = " ,";

                foreach (var ProgressionData in GenerateProgressDictionary(sessionData))
                {
                    firstLine += $"{ProgressionData.Key},";

                    for (int i = 0; i < ProgressionData.Value.Count; i++)
                    {
                        if (i < CSVLine.Count)
                            CSVLine[i] += $"{ProgressionData.Value[i]},";
                        else
                            CSVLine.Add($"{StartingRowLine}, {ProgressionData.Value[i]},");
                    }
                }

                textWriter.WriteLine(firstLine);

                foreach (var item in CSVLine)
                    textWriter.WriteLine(item);

                textWriter.Close();
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }

        public static Dictionary<string, List<string>> GenerateProgressDictionary(SessionData sessionData)
        {
            Dictionary<string, List<string>> progressEventNames = new Dictionary<string, List<string>> ();

            foreach (var progressEvent in sessionData.trackedProgressions)
            {
                if (!progressEventNames.ContainsKey(progressEvent.eventName))
                    progressEventNames.Add(progressEvent.eventName, new List<string>() { progressEvent.timeStamp.ToString() });
                else
                    progressEventNames[progressEvent.eventName].Add(progressEvent.timeStamp.ToString());
            }

            return progressEventNames;
        }
    }
}