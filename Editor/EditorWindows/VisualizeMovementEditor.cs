using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.Linq;
using PlaytestingTool;

namespace PlaytestingTool
{
    public class VisualizeMovementEditor : EditorWindow
    {
        public List<PlayerData> PlayersData = new List<PlayerData>();
        public List<PlayerData> ChosenPlayersData = new List<PlayerData>();

        public List<string> areasWithin = new List<string>();
        private string areaBreakdownText;

        bool StyleNotSet = true;
        GUIStyle lableStyle;
        GUILayoutOption[] SliderStyle;

        // -- GUI VARIABLES --

        //data selected
        public List<string> choices = new List<string>();

        int dataFlags = 0;

        //labels
        string SceneName;

        //timeline 
        int TimelineValue = 0;
        int minTime = 0;
        int MaxTime;

        //toggle buttons
        bool drawAreas = false;
        bool drawPaths = false;

        //area points
        public List<AreaPoints> areaPoints = new List<AreaPoints>();
        SerializedProperty propAreaPoints;

        //
        Vector2 PosOverFlow;
        Vector2 GUIOverflow;


        SerializedObject so;

        [MenuItem("Tools/Visualizers/VisualizeMovement")]
        static void Init() => GetWindow<VisualizeMovementEditor>("Data Visualizer");

        void InitStyle()
        {
            StyleNotSet = false;

            lableStyle = new GUIStyle(GUI.skin.label)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 30,
                fontStyle = FontStyle.Bold,

            };

            SliderStyle = new GUILayoutOption[]
            {
                GUILayout.Height(48),
            };
        }

        void OnEnable()
        {
            so = new SerializedObject(this);
            propAreaPoints = so.FindProperty("areaPoints");
            SceneName = EditorSceneManager.GetActiveScene().name;
            GetPlayersData();
            ChosenPlayerData();

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
            GUIOverflow = GUILayout.BeginScrollView(GUIOverflow, false, true);

            GUILayout.Label("Choose Player Data:");

            if (choices.Count > 1)
            {
                dataFlags = EditorGUILayout.MaskField("Player Data", dataFlags, choices.ToArray());
                if (GUILayout.Button("Select"))
                    ChosenPlayerData();
            }
            else
                GUILayout.Label("No Data Collected Yet");

            GUILayout.Label($"You are in scene: {SceneName}", EditorStyles.boldLabel);

            DrawUILine(Color.grey);

            drawPaths = GUILayout.Toggle(drawPaths, "Draw Player Paths");

            if (drawPaths)
            {
                DrawUILine(Color.grey);

                GUILayout.Label("Timeline");
                TimelineValue = Mathf.RoundToInt(GUILayout.HorizontalSlider(TimelineValue, 0, MaxTime));
                GUILayout.Label(" ");

            }

            drawAreas = GUILayout.Toggle(drawAreas, "Draw Areas");

            if (drawAreas)
            {
                DrawUILine(Color.grey);

                GUILayout.Label(" ");
                EditorGUILayout.PropertyField(propAreaPoints);

                if (GUILayout.Button("Check Bounds"))
                    CheckAreaBoundsButton();

                PosOverFlow = GUILayout.BeginScrollView(PosOverFlow, false, true);
                GUILayout.Label(" ");
                GUILayout.Label(areaBreakdownText);

                GUILayout.EndScrollView();
            }

            GUILayout.EndScrollView();
        }

        public static void DrawUILine(Color color, int thickness = 2, int padding = 10)
        {
            Rect r = EditorGUILayout.GetControlRect(GUILayout.Height(padding + thickness));
            r.height = thickness;
            r.y += padding / 2;
            r.x -= 2;
            r.width += 6;
            EditorGUI.DrawRect(r, color);
        }


        void ChosenPlayerData()
        {
            ChosenPlayersData.Clear();

            for (int i = 0; i < PlayersData.Count; i++)
            {
                if ((dataFlags & (1 << i)) == (1 << i)) ChosenPlayersData.Add(PlayersData[i]);
            }

            SceneView.RepaintAll();
        }


        void CheckAreaBoundsButton()
        {
            areaBreakdownText = "";
            foreach (var playerdata in ChosenPlayersData)
            {
                Dictionary<string, int> areasBound = CalculationLib.ContainsVectors(playerdata.trackedPositions, areaPoints);
                foreach (var item in areasBound)
                {
                    areaBreakdownText = $"{ playerdata.UniqueID} \n In area: {item.Key} Count: {item.Value} \n \n {areaBreakdownText}";
                }
            }
        }

        void DuringSceneGUI(SceneView sceneView)
        {
            if (StyleNotSet) InitStyle();
            
            if(drawPaths)
                DrawLib.drawPath(MaxTime, TimelineValue, ChosenPlayersData);
            if(drawAreas)
                DrawLib.DrawAreas(areaPoints, so);

            SceneView.RepaintAll();
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