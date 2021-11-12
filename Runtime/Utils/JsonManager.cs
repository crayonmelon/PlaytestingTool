using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

namespace PlaytestingTool
{
    public class JsonManager
    {
        public static void SavePlayerDatJson(PlayerData playerData, string fileName)
        {
            try
            {
                string json = JsonUtility.ToJson(playerData, true);
                string path = "./Assets/PlayerData/";
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