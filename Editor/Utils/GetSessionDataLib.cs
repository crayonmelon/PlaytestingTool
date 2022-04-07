using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.IO;
using System;
namespace PlaytestingTool
{
    public class GetSessionDataLib : Editor
    {
        /// <summary>
        /// Returns a List of Strings containing the names of all session Data
        /// used to populate the choices dropdown
        /// </summary>
        /// <param name="specificScene">If you want data to be from the specific scene opened</param>
        /// <returns>Names of session data ie. </returns>
        /// 
#if UNITY_EDITOR
        public static List<string> GetSessionDataChoices(bool specificScene)
        {
            List<string> choices = new List<string>();
            string SceneName = EditorSceneManager.GetActiveScene().name;

            Settings.LoadSettings();

            string path = $"{Settings.FOLDERPATH}";

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string[] allDir = Directory.GetDirectories(path);
            //ChosenPlayersData.Clear();

            foreach (string dir in allDir)
            {
                string LevelName = new DirectoryInfo(dir).Name;

                string[] allFiles = Directory.GetFiles($"{path}/{LevelName}/", "*.json");

                foreach (string file in allFiles)
                {
                    SessionData playerDataTemp;

                    file.Contains(SceneName);
                    playerDataTemp = PlaySessionDataManager.LoadPlayerDataJson($"{LevelName}/{Path.GetFileName(file)}");

                    if (playerDataTemp == null)
                    {
                        continue;
                    }

                    if (!specificScene || playerDataTemp.SceneName == SceneName)
                    {
                        choices.Add(LevelName);
                    }
                }
            }


            return choices;
        }
#endif

        /// <summary>
        /// 
        /// </summary>
        /// <param name="choices"></param>
        /// <param name="dataFlags"></param>
        /// <param name="specificScene"></param>
        /// <returns></returns>
        public static List<SessionData> GetChosenSessionData(List<string> choices, int dataFlags, bool specificScene)
        {
            List<SessionData> ChosenSessionData = new List<SessionData>();
            //ChosenPlayersData.Clear();
            string SceneName = EditorSceneManager.GetActiveScene().name;

            for (int i = 0; i < choices.Count; i++)
            {
                if ((dataFlags & (1 << i)) == (1 << i))
                {
                 //   Debug.Log(choices[i]);
                    //    playerDataTemp = PlaySessionDataManager.LoadPlayerDataJson(Path.GetFileName(file));
                    string[] allFiles = Directory.GetFiles($"{Settings.FOLDERPATH}/{choices[i]}/", "*.json");

                    foreach (string file in allFiles)
                    {
                        SessionData playerDataTemp;

                        file.Contains(SceneName);
                        playerDataTemp = PlaySessionDataManager.LoadPlayerDataJson($"{choices[i]}/{Path.GetFileName(file)}");

                        if (playerDataTemp.SceneName == SceneName)
                        {
                            ChosenSessionData.Add(playerDataTemp);
                        }
                    }
                }
            }

            return ChosenSessionData;
            //SceneView.RepaintAll();
        }
    }


}
