using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using UnityEngine.Networking;

namespace PlaytestingTool
{
    public class PlaySessionDataManager
    {
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
               
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                File.WriteAllText(path + file, json);
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }

        public static SessionData LoadPlayerDataJson(string fileName)
        {
            try
            {
                string path = $"{Settings.FOLDERPATH }/ ";

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

        public static IEnumerator UploadData(string file)
        {
            byte[] myData = System.Text.Encoding.UTF8.GetBytes(file);
            UnityWebRequest www = UnityWebRequest.Put("https://www.my-server.com/upload", myData);
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
    }
}