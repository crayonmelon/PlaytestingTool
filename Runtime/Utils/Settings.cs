using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

namespace PlaytestingTool
{
    public class Settings 
    {
        private static string _FOLDERPATH;
        private static string _WEBENDPOINT;
        private static string _PULLREQUESTLINK;
        private static bool _UPLOADDATA;
        private static bool _ENABLE;

        public static void SaveSettings(SettingsData settingsData = null)
        {

            if (settingsData == null)
            {
                settingsData = new SettingsData(FOLDERPATH, WEBENDPOINT, UPLOADDATA, ENABLE, PULLREQUESTLINK);
            }

            //Save JSON
            try
            {
                string json = JsonUtility.ToJson(settingsData, true);
                string path = $"{Application.dataPath}/Settings/";
                string file = $"settingsData.json";

                if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                File.WriteAllText(path + file, json);

            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }

        public static void LoadSettings()
        {
            try
            {
                string path = $"{Application.dataPath}/Settings/";

                Debug.Log(path);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (!File.Exists(path + "settingsData.json"))
                    CreateDefaultFile();

                string json = File.ReadAllText(path + "settingsData.json");
                SettingsData settingsData = new SettingsData();

                JsonUtility.FromJsonOverwrite(json, settingsData);

                FOLDERPATH = settingsData.FolderPath;
                WEBENDPOINT = settingsData.WebEndpoint;
                ENABLE = settingsData.EnableSaveData;
                UPLOADDATA = settingsData.EnableUploadData;
                PULLREQUESTLINK = settingsData.PullRequestLink;

            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }

        public static void CreateDefaultFile()
        {
            SettingsData settingsData = new SettingsData("Assets/SessionData", "http://localhost:3000/sessionData", false, true, "http://localhost:3000/getAllData");
            SaveSettings(settingsData);
        }

        public static string FOLDERPATH
        {
            get { return _FOLDERPATH; }
            set { _FOLDERPATH = value;  }
        }

        public static string WEBENDPOINT
        {
            get { return _WEBENDPOINT; }
            set { _WEBENDPOINT = value; }
        }

        public static bool ENABLE
        {
            get { return _ENABLE; }
            set { _ENABLE = value; }
        }

        public static bool UPLOADDATA
        {
            get { return _UPLOADDATA; }
            set { _UPLOADDATA = value; }
        }
        public static string PULLREQUESTLINK
        {
            get { return _PULLREQUESTLINK; }
            set { _PULLREQUESTLINK = value; }
        }
    }


    [System.Serializable]
    public class SettingsData
    {
        public string FolderPath;
        public string WebEndpoint;
        public bool EnableUploadData;
        public bool EnableSaveData;
        public string PullRequestLink;

        public SettingsData(string folderPath, string webEndpoint, bool enableUploadData, bool enableSaveData, string pullRequestLink)
        {
            FolderPath = folderPath;
            WebEndpoint = webEndpoint;
            EnableUploadData = enableUploadData;
            EnableSaveData = enableSaveData;
            PullRequestLink = pullRequestLink;
        }

        public SettingsData()
        {
        }
    }
}


//namespace PlaytestingTool
//{
//    public class Settings
//    {
//        private static bool _ENABLE = true;

//        public static string EnableSavingName = "ENABLE_SAVING";
//        public static string EnableUploadDataName = "ENABLE_UPLOAD_DATA";
//        public static string LocalFolderPathName = "LOCAL_FOLDER_PATH";
//        public static string PushServerEndPointName = "SERVER_ENDPOINT";


//        public static string FOLDERPATH
//        {
//            get { return PlayerPrefs.GetString(LocalFolderPathName); }
//            set { PlayerPrefs.SetString(LocalFolderPathName, value); }
//        }

//        public static string WEBENDPOINT
//        {
//            get { return PlayerPrefs.GetString(PushServerEndPointName); }
//            set { PlayerPrefs.SetString(PushServerEndPointName, value); }
//        }

//        public static bool ENABLE
//        {
//            get { return PlayerPrefs.GetBool(EnableSavingName); }
//            set { PlayerPrefs.SetBool(EnableUploadDataName, value); }
//        }

//        public static bool UPLOADDATA
//        {
//            get { return PlayerPrefs.GetBool(EnableUploadDataName); }
//            set { PlayerPrefs.SetBool(EnableUploadDataName, value); }
//        }
//    }

//}