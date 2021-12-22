using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlaytestingTool
{
    public class PlaySessionDataManager
    {
        public static void SavePlayerDatJson(PlayerData playerData, string fileName)
        {
            string folderName = $"{DateTime.Now:dd-MM-yy HH.mm.ss} PlaySession";
            Debug.Log(folderName);

            //FileStream fs = new FileStream($"./Assets/PlayerData/{folderName}/{fileName}.dat", FileMode.Create);
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
                string path = $"./Assets/PlayerData/{folderName}/";
                string file = $"PlayerData {fileName}.json";
               
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                File.WriteAllText(path + file, json);
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }

        public static PlayerData LoadPlayerDataJson(string fileName)
        {
            try
            {
                string path = "./Assets/PlayerData/";

                string json = File.ReadAllText(path + fileName);
                PlayerData playerdata = new PlayerData();
                JsonUtility.FromJsonOverwrite(json, playerdata);

                return playerdata;
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
                return null;
            }

        }
    }
}