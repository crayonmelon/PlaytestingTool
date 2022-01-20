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
        public List<SessionData> AllPlayersData = new List<SessionData>();

        private List<SessionData> ChosenPlayersData = new List<SessionData>();
        private List<TrackedProgressionEvent> trackedProgressionEvents = new List<TrackedProgressionEvent>();
        private List<TrackedProgressionEvent> chosenTrackedProgression = new List<TrackedProgressionEvent>();


        //data selected
        public List<string> choices = new List<string>();
        string SceneName;
        int dataFlags = 0;

        [MenuItem("Tools/Visualizers/HeatMap")]
        static void Init() => GetWindow<HeatMapWindow>("HeatMap Visualizer");

        void OnEnable()
        {
            GetPlayersData();

            SceneView.duringSceneGui += this.DuringSceneGUI;
            Selection.selectionChanged += Repaint;

            SceneName = EditorSceneManager.GetActiveScene().name;
        }

        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
            SceneView.duringSceneGui += this.DuringSceneGUI;
        }

        public void OnGUI()
        {
            GUILayout.Label("Choose Player Data:");

            if (choices.Count >= 1)
            {
                dataFlags = EditorGUILayout.MaskField("Player Data", dataFlags, choices.ToArray());
                if (GUILayout.Button("Select"))
                    SetChosenProgressData();
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
            AllPlayersData.Clear();

            foreach (string dir in allDir)
            {
                string LevelName = new DirectoryInfo(dir).Name;
                string[] allFiles = Directory.GetFiles($"./Assets/PlayerData/{LevelName}/", "*.json");

                Debug.Log($"size: {allFiles.Length}");

                foreach (string file in allFiles)
                {
                    SessionData playerDataTemp;
                    playerDataTemp = PlaySessionDataManager.LoadPlayerDataJson($"{LevelName}/{Path.GetFileName(file)}");
                    AllPlayersData.Add(playerDataTemp);
                    Debug.Log("Data: " + playerDataTemp);

                }
            }
            Debug.Log($"All Data Size {AllPlayersData.Count} ");
            SetProgressChoices();
        }

        void SetProgressChoices()
        {
            choices.Clear();

            foreach (var playerData in AllPlayersData)
            {
                foreach (var progression in playerData.trackedProgressions)
                {
                    Debug.Log($"{progression} who is joe?");
                    trackedProgressionEvents.Add(progression);

                    if (!choices.Contains(progression.eventName))
                    {
                        choices.Add(progression.eventName);
                    }
                }
            }
        }

        void SetChosenProgressData()
        {
            ChosenPlayersData.Clear();
            chosenTrackedProgression.Clear();

            for (int i = 0; i < choices.Count; i++)
            {
                if ((dataFlags & (1 << i)) == (1 << i))
                {
                    Debug.Log(choices[i]);

                    foreach (var item in trackedProgressionEvents)
                    {
                        if (choices[i] == item.eventName)
                        {
                            chosenTrackedProgression.Add(item);
                        }
                    }
                }
            }

            DrawHeatMap();
        }

        void DrawHeatMap()
        {
            foreach (var item in chosenTrackedProgression)
            {
                Debug.Log($"Time: {item.eventName} at {item.eventName}");
            }
        }

    }
}


