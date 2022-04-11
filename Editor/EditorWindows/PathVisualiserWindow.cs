using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.Linq;

namespace PlaytestingTool
{
    public class PathVisualiserWindow : EditorWindow
    {
        public List<SessionData> ChosenSessionData = new List<SessionData>();
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
        public static float iconSize = 1;

        //timeline 
        int TimelineValue = 0;
        int MaxTime;

        //toggle buttons
        bool drawAreas = false;
        bool drawPaths = false;
        bool drawText = false;


        //area points
        public List<AreaPoints> areaPoints = new List<AreaPoints>();
        SerializedProperty propAreaPoints;

        Vector2 PosOverFlow;
        Vector2 GUIOverflow;

        SerializedObject so;

        [MenuItem("Tools/PlayTesting Tool/Visualisers/Path Visualiser")]
        static void Init() => GetWindow<PathVisualiserWindow>("Path Visualiser");

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
            SerializedProperty iconSizeSerilised = so.FindProperty("iconSize");

            propAreaPoints = so.FindProperty("areaPoints");
            SceneName = EditorSceneManager.GetActiveScene().name;
            GetPlayersData();
            SetChosenPlayerData();

            Selection.selectionChanged += Repaint;
            SceneView.duringSceneGui += this.DuringSceneGUI;
            EditorSceneManager.sceneOpened += SceneChange;
            EditorApplication.playModeStateChanged += stateChanged;
        }

        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
            SceneView.duringSceneGui -= this.DuringSceneGUI;
            EditorSceneManager.sceneOpened -= SceneChange;
        }

        public void OnGUI()
        {
            GUIOverflow = GUILayout.BeginScrollView(GUIOverflow, false, false);
            GUILayout.BeginVertical("box", GUILayout.Width(300));


            if (choices.Count >= 1)
            {
                GUILayout.Label(new GUIContent("Choose Session Data:", "A list of session data folders with tracked position data in them. \n Select the data you wish to visualise."));

                GUILayout.BeginHorizontal("box");
                dataFlags = EditorGUILayout.MaskField(dataFlags, choices.ToArray());

                if (GUILayout.Button(new GUIContent("Select", "Hio")))
                {
                    SetChosenPlayerData();
                    drawPaths = true;
                }

                GUILayout.EndHorizontal();
                GUILayout.Label($"(Data From Scene: {SceneName})", EditorStyles.boldLabel);
                
            }
            else
                GUILayout.Label("No Data Collected Yet");

            if (ChosenSessionData.Count > 0)
            {
                if (drawPaths)
                {
                    DrawLib.DrawUILine(Color.grey);

                    GUILayout.Label("Timeline");
                    TimelineValue = Mathf.RoundToInt(GUILayout.HorizontalSlider(TimelineValue, 0, MaxTime));
                    GUILayout.Label(" ");

                }

                DrawLib.DrawUILine(Color.grey);
                GUILayout.Label("Settings");
                drawPaths = GUILayout.Toggle(drawPaths, "Draw Player Paths");
                drawText = GUILayout.Toggle(drawText, "Draw Text Label");
                iconSize = EditorGUILayout.Slider("Icon Size", iconSize, .1f, 15);

                DrawLib.DrawUILine(Color.grey);
                drawAreas = GUILayout.Toggle(drawAreas, "Draw Areas");
            }
   
            if (drawAreas)
            {
                if (areaPoints.Count == 0)
                    areaPoints.Add(new AreaPoints(new Vector3(10, 10, 10), new Vector3(0, 0, 0), new Color(1, 1, 1, 1), "Area_One", new Bounds(new Vector3(5, 5, 5), new Vector3(5, 5, 5))));

                DrawLib.DrawUILine(Color.grey);

                GUILayout.Label(" ");
                EditorGUILayout.PropertyField(propAreaPoints);

                if (GUILayout.Button("Check Bounds"))
                    CheckAreaBoundsButton();

                GUILayout.Label(" ");
                GUILayout.Label(areaBreakdownText);

            }

            GUILayout.EndVertical();
            GUILayout.EndScrollView();
        }

        void CheckAreaBoundsButton()
        {
            areaBreakdownText = "";
            foreach (var playerdata in ChosenSessionData)
            {
                Dictionary<string, int> areasBound = CalculationLib.ContainsVectors(playerdata.trackedPositions, areaPoints);
                foreach (var item in areasBound)
                {
                    areaBreakdownText = $"{ playerdata.objectName} \n In area: {item.Key} Count: {item.Value} \n \n {areaBreakdownText}";
                }
            }
        }

        void DuringSceneGUI(SceneView sceneView)
        {
            if (StyleNotSet) InitStyle();
            
            if(drawPaths)
            {
                for (int k = 0; k < ChosenSessionData.Count; k++)
                {
                    var playerData = ChosenSessionData[k];
                    if (MaxTime < playerData.trackedPositions.Count)
                    {
                        MaxTime = playerData.trackedPositions.Count;
                    }
                }
                
                DrawLib.drawPath(MaxTime, TimelineValue, ChosenSessionData);
            }

            if(drawAreas)
                DrawLib.DrawAreas(areaPoints, so);

            SceneView.RepaintAll();
        }

        void SceneChange(Scene scene, OpenSceneMode mode)
        {
            SceneName = scene.name;
            GetPlayersData();
        }

        void SetChosenPlayerData()
        {
            ChosenSessionData = GetSessionDataLib.GetChosenSessionData(choices, dataFlags, true);
            SceneView.RepaintAll();
        }

        void GetPlayersData()
        {
            choices = GetSessionDataLib.GetSessionDataChoices(true);
        }

        void stateChanged(PlayModeStateChange state)
        {
            if(state == PlayModeStateChange.EnteredEditMode)
            {
                GetPlayersData();
            }
        }
    }
}