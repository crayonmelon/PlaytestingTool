using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

namespace PlaytestingTool
{
    public class VisualizeMovementEditor : EditorWindow
    {
        public List<PlayerData> PlayersData = new List<PlayerData>();
        public List<PlayerData> ChosenPlayersData = new List<PlayerData>();

        public PlayerData playerData;
        List<TrackedPosition> tp;
        string SceneName;

        public List<string> choices = new List<string>();
        public int index = 0;

        GUIStyle lableStyle;
        bool StyleNotSet = true;

        int flags = 0;

        [MenuItem("Tools/Visualizers/VisualizeMovement")]
        static void Init() => GetWindow<VisualizeMovementEditor>();
        void InitStyle()
        {
            StyleNotSet = false;

            Debug.Log("style");
            lableStyle = new GUIStyle(GUI.skin.label)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 30,
                fontStyle = FontStyle.Bold,

            };
        }

        void OnEnable()
        {
            SceneName = EditorSceneManager.GetActiveScene().name;
            GetPlayersData();
            Chosen();

            Selection.selectionChanged += Repaint;
            SceneView.duringSceneGui += this.DuringSceneGUI;
            EditorSceneManager.sceneOpened += SceneChange; 
        }

        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
            SceneView.duringSceneGui -= this.DuringSceneGUI;
            EditorSceneManager.sceneOpened -= SceneChange;
        }

        public void OnGUI()
        {
            GUILayout.Label("Choose Player Data:");
            GUILayout.Label(SceneName);

            //index = EditorGUILayout.Popup("Player Data",index, choices.ToArray());

            if(choices.Count > 1)
            {
                flags = EditorGUILayout.MaskField("Player Data", flags, choices.ToArray());
                if (GUILayout.Button("Select"))
                    Chosen();
            }
            else
                GUILayout.Label("No Data Collected Yet");
        }

        void Chosen()
        {
            ChosenPlayersData.Clear();

            for (int i = 0; i < PlayersData.Count; i++)
            {
                if ((flags & (1 << i)) == (1 << i)) ChosenPlayersData.Add(PlayersData[i]);
            }
            playerData = JsonManager.LoadPlayerDataJson(choices[index]);
            tp = playerData.trackedPositions;
            SceneView.RepaintAll();
        }

        void DuringSceneGUI(SceneView sceneView)
        {
            if (StyleNotSet) InitStyle();

            Handles.color = new Color(1, 1f, 0.4f, 1);

            foreach (var playerData in ChosenPlayersData)
            {
                Handles.CubeHandleCap(
                0,
                playerData.trackedPositions[0].trackedPosition,
                Quaternion.LookRotation(Vector3.up),
                1f,
                EventType.Repaint);

                for (int i = 0; i < playerData.trackedPositions.Count; i++)
                {
                    if (i > 0 && i < playerData.trackedPositions.Count)
                    {
                        Handles.DrawLine(playerData.trackedPositions[i - 1].trackedPosition, 
                            playerData.trackedPositions[i].trackedPosition, 10);
                    }
                }

                Handles.CubeHandleCap(
                0,
                playerData.trackedPositions[playerData.trackedPositions.Count-1].trackedPosition,
                Quaternion.LookRotation(Vector3.up),
                1f,
                EventType.Repaint);
            }
        }

        void SceneChange(Scene scene, OpenSceneMode mode)
        {
            SceneName = scene.name;

            GetPlayersData();
        }

        void GetPlayersData()
        {
            PlayerData playerDataTemp;
            string path = "./Assets/PlayerData/";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string[] allFiles = Directory.GetFiles("./Assets/PlayerData", "*.json");

            PlayersData.Clear();
            ChosenPlayersData.Clear();
            choices.Clear();

            foreach (string file in allFiles)
            {
                Debug.Log(file);
                file.Contains(SceneName);
                playerDataTemp = JsonManager.LoadPlayerDataJson(Path.GetFileName(file));

                if(playerDataTemp.SceneName == SceneName)
                {
                    choices.Add(Path.GetFileName(file));
                    PlayersData.Add(playerDataTemp);
                }
            }
        }
    }

}