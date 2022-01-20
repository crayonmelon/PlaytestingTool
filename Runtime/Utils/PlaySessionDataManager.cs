using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlaytestingTool
{
    public class PlaySessionDataManager
    {
        public static void SavePlayerDatJson(SessionData playerData, string fileName)
        {
            string folderName = $"{DateTime.Now:dd-MM-yy HH.mm.ss} PlaySession";
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
                string json = JsonUtility.ToJson(playerData, true);
                string path = $"./Assets/SessionData/{folderName}/";
                string file = $"SessionData {fileName}.json";
               
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
                string path = "./Assets/SessionData/";

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
    }
}