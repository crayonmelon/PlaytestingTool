using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using UnityEngine.Networking;
using System.Net;
using System.Data.SqlTypes;

namespace PlaytestingTool
{
    public class PlaySessionDataManager
    {
        private const string V = "\result.zip";

        public static void SavePlayerDatJson(SessionData sessionData)
        {
            string folderName = $"{DateTime.Now:dd-MM-yy} PlaySession {sessionData.sessionName.Substring(0, 4)}";
            Debug.Log($"DATA CREATED <a href={folderName} line={folderName}</a>");

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
                string path = $"./Assets/SessionData/{folderName}/";
                string file = $"SessionData {sessionData.objectName}.json";
                int fileCount = 0;

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

        public static SessionData LoadPlayerDataJson(string fileName)
        {
            Debug.Log($"Path {Settings.FOLDERPATH}{fileName}");

            
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

        public static IEnumerator UploadData(SessionData file)
        {
            Debug.Log("we started!");
            string json = JsonUtility.ToJson(file, true);

            byte[] myData = System.Text.Encoding.UTF8.GetBytes(json);
            UnityWebRequest www = UnityWebRequest.Put(Settings.WEBENDPOINT, myData);
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Upload complete!");
            }

        } 

        public static void UploadSessionData(string filename)
        {
            string path = $"{Settings.FOLDERPATH}/";
            string json = File.ReadAllText(path + filename);
            Debug.Log(json);
            WebClient myWebClient = new WebClient();
            myWebClient.Encoding = System.Text.Encoding.UTF8;
            myWebClient.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8");

            string responseArray = myWebClient.UploadString("http://localhost:3000/sessionData", "POST", json);

            Debug.Log(responseArray);
        }
    }
}