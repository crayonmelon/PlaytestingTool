using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.IO;

namespace PlaytestingTool
{
    public class HeatMapWindow : EditorWindow
    {
        public List<PlayerData> ChosenPlayersData = new List<PlayerData>();

        //data selected
        public List<string> choices = new List<string>();
        string SceneName;
        int dataFlags = 0;

        [MenuItem("Tools/Visualizers/HeatMap")]
        static void Init() => GetWindow<HeatMapWindow>("HeatMap Visualizer");

        void OnEnable()
        {
            SceneView.duringSceneGui += this.DuringSceneGUI;
            Selection.selectionChanged += Repaint;

            SceneName = EditorSceneManager.GetActiveScene().name;
            GetPlayersData();
            SetChosenPlayerData();
        }

        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
            SceneView.duringSceneGui -= this.DuringSceneGUI;
        }

        public void OnGUI()
        {
            GUILayout.Label("Choose Player Data:");

            if (choices.Count >= 1)
            {
                dataFlags = EditorGUILayout.MaskField("Player Data", dataFlags, choices.ToArray());
                //if (GUILayout.Button("Select"))
                //    SetChosenPlayerData();
            }
            else
                GUILayout.Label("No Data Collected Yet");
        }

        void DuringSceneGUI(SceneView sceneView)
        {
            SceneView.RepaintAll();
        }

        void GetPlayersData()
        {
            string path = "./Assets/PlayerData/";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string[] allDir = Directory.GetDirectories(path);
            ChosenPlayersData.Clear();
            choices.Clear();

            foreach (string dir in allDir)
            {
                string LevelName = new DirectoryInfo(dir).Name;
                string[] allFiles = Directory.GetFiles($"./Assets/PlayerData/{LevelName}/", "*.json");


                foreach (string file in allFiles)
                {
                    PlayerData playerDataTemp;

                    file.Contains(SceneName);
                    playerDataTemp = PlaySessionDataManager.LoadPlayerDataJson($"{LevelName}/{Path.GetFileName(file)}");

                    if (playerDataTemp.SceneName == SceneName)
                    {
                        choices.Add(LevelName);
                    }
                }
            }
        }

        void SetChosenPlayerData()
        {
            ChosenPlayersData.Clear();

            for (int i = 0; i < choices.Count; i++)
            {
                if ((dataFlags & (1 << i)) == (1 << i))
                {
                    Debug.Log(choices[i]);
                    //    playerDataTemp = PlaySessionDataManager.LoadPlayerDataJson(Path.GetFileName(file));
                    string[] allFiles = Directory.GetFiles($"./Assets/PlayerData/{choices[i]}/", "*.json");

                    foreach (string file in allFiles)
                    {
                        PlayerData playerDataTemp;

                        file.Contains(SceneName);
                        playerDataTemp = PlaySessionDataManager.LoadPlayerDataJson($"{choices[i]}/{Path.GetFileName(file)}");

                        if (playerDataTemp.SceneName == SceneName)
                        {
                            ChosenPlayersData.Add(playerDataTemp);
                        }
                    }
                }
            }

            SceneView.RepaintAll();
        }

    }
}


