using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.IO; 
using System;
using System.Linq;


namespace PlaytestingTool
{
    public class HeatMapWindow : EditorWindow
    {
        List<string> choices = new List<string>();
        int dataFlags = 0;
            
        List<SessionData> ChoosenSessionDataSets = new List<SessionData>();

        Vector2 GUIOverflow;

        Dictionary<string, bool> progressEventNames = new Dictionary<string, bool>();
        Dictionary<string, List<Vector3>> progressEventPos = new Dictionary<string, List<Vector3>>();

        Vector3Int resolution = new Vector3Int(20, 1, 20);
        int threshold = 1;
        float highestThreshold = 10f;

        [MenuItem("Tools/PlayTesting Tool/Visualisers/Heat Map")]
        static void Init() => GetWindow<HeatMapWindow>("HeatMap Visualiser");

        //SerializedObjects 
        SerializedObject so;
        float iconSize = 1;

        Dictionary<Vector3, int> heatMapGrid = new Dictionary<Vector3, int>();
        Vector3 sizeSection;
        bool drawMesh, drawSolid;

        int chosenHeatMapIndex = 0;
        string [] heatMapOptions;

        string SceneName;
        bool warningPopup = false;

        GUIStyle testStyle = new GUIStyle();
        Color startColor = Color.white;
        Color endColor = Color.red;

        private void OnEnable()
        {
            RefreshAllData();

            Selection.selectionChanged += Repaint;
            SceneView.duringSceneGui += this.DuringSceneGUI;
            EditorSceneManager.sceneOpened += SceneChange;
            EditorApplication.playModeStateChanged += stateChanged;

            // Warning Style 
            testStyle.richText = true;
        }

        private void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
            SceneView.duringSceneGui -= this.DuringSceneGUI;
            EditorSceneManager.sceneOpened -= SceneChange;
            EditorApplication.playModeStateChanged -= stateChanged;
        }
        void OnInspectorUpdate()
        {
            SceneView.RepaintAll();
        }

        void stateChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.EnteredEditMode)
                RefreshAllData();
        }

        private void RefreshAllData()
        {
            choices = GetSessionDataLib.GetSessionDataChoices(true);
            GetChosenData();
            heatMapGrid.Clear();
            SceneName = EditorSceneManager.GetActiveScene().name;

        }

        void SceneChange(Scene scene, OpenSceneMode mode)
        {
            RefreshAllData();
        }

        private void OnGUI()
        {
            GUIOverflow = GUILayout.BeginScrollView(GUIOverflow, false, false);
            GUILayout.BeginVertical("box", GUILayout.Width(300));

            if (choices.Count >= 1)
            {
                GUILayout.Label(new GUIContent("Choose Session Data:", "A list of session data folders with progression data with position data and position data.Select the data you wish to visualise."));

                GUILayout.BeginHorizontal("box");
                dataFlags = EditorGUILayout.MaskField(dataFlags, choices.ToArray());

                if (GUILayout.Button("Select"))
                {
                    GetChosenData();
                }
                GUILayout.EndHorizontal();
                GUILayout.Label($"(Data From Scene: {SceneName})", EditorStyles.boldLabel);

            }
            else
                GUILayout.Label("No Data Collected Yet");

            if (ChoosenSessionDataSets.Count > 0)
            {
                GUILayout.Label(new GUIContent("choose data for Heat map:", "options of events to draw a heatmap.\nGenerated from progression events as well as positional data."));
                heatMapOptions = progressEventNames.Keys.ToArray();
                chosenHeatMapIndex = EditorGUILayout.Popup(chosenHeatMapIndex, heatMapOptions);


                if (GUILayout.Button("Draw Heatmap", GUILayout.Width(300)))
                {
                    warningPopup = true;
                    // InitHeatMapGrid(resolution);
                    // CheckBounds();
                    //drawMesh = true;
                }

                if (warningPopup)
                {
                    DrawLib.DrawUILine(Color.red);
                    GUILayout.Label("<b><color=yellow><size=20>WARING</size></color></b>", testStyle);
                    GUILayout.Label($"generating Heatmap may take time if your\n resolution is too high. \n We recommend starting at a smaller resolution\n and increment from there.");

                    GUILayout.Label($"Your resolution is: ({resolution.x} x {resolution.y} x {resolution.z})");

                    if (GUILayout.Button("Okay", GUILayout.Width(300)))
                    {
                        warningPopup = false;
                        InitHeatMapGrid(resolution);
                        CheckBounds();
                        drawMesh = true;
                    }

                    DrawLib.DrawUILine(Color.red);
                }

                DrawLib.DrawUILine(Color.grey);

                GUILayout.Label("Heatmap Settings");

                threshold = (int)EditorGUILayout.Slider(new GUIContent("threshold", "Minimum amount of 3d Points needed to be drawn in the scene view.\n 0 = all cells"), threshold, 0, 10);
                resolution.x = (int)EditorGUILayout.Slider(new GUIContent("resolutionX", "The number of cells in the heatmap grid on the X axis"), resolution.x, 1, 100);
                resolution.y = (int)EditorGUILayout.Slider(new GUIContent("resolutionY", "The number of cells in the heatmap grid on the Y axis"), resolution.y, 1, 100);
                resolution.z = (int)EditorGUILayout.Slider(new GUIContent("resolutionZ", "The number of cells in the heatmap grid on the Z axis"), resolution.z, 1, 100);

                startColor = EditorGUILayout.ColorField(new GUIContent("Start Color", "The cell drawn will be a colour between `Start Colour` and `End Color` two colours.\nStart Colour: 0 points in the cell"), startColor);
                endColor = EditorGUILayout.ColorField(new GUIContent("End Color", "The cell drawn will be a colour between `Start Colour` and `End Color` two colours.\nEnd Colour: max points in the cell."), endColor);

                DrawLib.DrawUILine(Color.grey);

                drawMesh = EditorGUILayout.Toggle(new GUIContent("Draw Mesh", "Draw a mesh grid to represent the cell."), drawMesh);
                drawSolid = EditorGUILayout.Toggle(new GUIContent("Draw Solid", "Draw a solid cube to represent the cell."), drawSolid);

                DrawLib.DrawUILine(Color.grey);

                GUILayout.Label("Session Position Data Points:");

                for (int i = 0; i < progressEventNames.Keys.Count; i++)
                {
                    var eventName = new List<string>(progressEventNames.Keys)[i];
                    // string eventName = progressEventNames.Keys.ToList()[i];
                    progressEventNames[eventName] = GUILayout.Toggle(progressEventNames[eventName], new GUIContent(eventName, $"Draws the 3D points of {eventName}"));
                }

                DrawLib.DrawUILine(Color.grey);

                GUILayout.Label("Points Settings");
                iconSize = EditorGUILayout.Slider(new GUIContent("icon Size", "size of the 3D point drawn on the scene"), iconSize, .1f, 15);
                DrawLib.DrawUILine(Color.grey, 2);


            }

            GUILayout.EndVertical();
            GUILayout.EndScrollView();

            GUILayout.FlexibleSpace();

            if (GUILayout.Button("Refresh", GUILayout.Width(300)))
            {
                choices = GetSessionDataLib.GetSessionDataChoices(true);
                Selection.selectionChanged += Repaint;

            }
        }

        void DuringSceneGUI(SceneView sceneView)
        {
            Handles.color = Color.white;

            foreach (var sessionData in ChoosenSessionDataSets)
            {
                foreach (var progressEvent in sessionData.trackedProgressions)
                {
                    if (progressEventNames.ContainsKey(progressEvent.eventName) && progressEventNames[progressEvent.eventName])
                    {
                        Handles.SphereHandleCap(0, progressEvent.trackedPosition, Quaternion.LookRotation(Vector3.up), iconSize, EventType.Repaint);
                    }
                }
            }

            drawGrid();
            SceneView.RepaintAll();
        }

        void InitHeatMapGrid(Vector3Int resolution)
        {
            Tuple<Vector3, Vector3>  edgesTuple = setEdgeVectors(progressEventPos[heatMapOptions[chosenHeatMapIndex]]);

            Vector3 startPos = edgesTuple.Item1;
            Vector3 endPos = edgesTuple.Item2;
            heatMapGrid.Clear();

            Debug.Log($"{startPos} {endPos}");

            Vector3 CenterVector = Vector3.Lerp(startPos, endPos, 0.5f);
            Vector3 size = new Vector3(Mathf.Abs(startPos.x - endPos.x), Mathf.Abs(startPos.y - endPos.y), Mathf.Abs(startPos.z - endPos.z));

            sizeSection = new Vector3(
                Math.Abs(startPos.x - endPos.x) / resolution.x,
                Math.Abs(startPos.y - endPos.y) / resolution.y,
                Math.Abs(startPos.z - endPos.z) / resolution.z);

            Handles.DrawWireCube(CenterVector, size);

            for (int x = 0; x < resolution.x; x++)
            {
                for (int y = 0; y < resolution.y; y++)
                {
                    for (int z = 0; z < resolution.z; z++)
                    {
                        Vector3 CenterSection = new Vector3(sizeSection.x * x, sizeSection.y * y, sizeSection.z * z);
                        Vector3 centerTotal = CenterSection + (endPos + (sizeSection / 2));

                        Bounds bounds = new Bounds(centerTotal, sizeSection);

                        //Handles.DrawWireCube(centerTotal, sizeSection);

                        heatMapGrid.Add(centerTotal, 0);
                    }
                }
            }
        }

        void GetChosenData()
        {
            ChoosenSessionDataSets = GetSessionDataLib.GetChosenSessionData(choices, dataFlags, true);
            //  Debug.Log(ChoosenSessionDataSets.Count);
            setProgressionEventnames();
        }

        void setProgressionEventnames()
        {
            progressEventNames.Clear();
            progressEventPos.Clear();
            foreach (var sessionData in ChoosenSessionDataSets)
            {
                foreach (var progressEvent in sessionData.trackedProgressions)
                {
                    if (!progressEventNames.ContainsKey(progressEvent.eventName))
                        progressEventNames.Add(progressEvent.eventName, false);

                    foreach (var progressName in progressEventNames.Keys)
                    {
                        if (progressEvent.eventName == progressName)
                        {
                            if (progressEventPos.ContainsKey(progressName))
                                progressEventPos[progressName].Add(progressEvent.trackedPosition);
                            else
                                progressEventPos.Add(progressEvent.eventName, new List<Vector3>());
                        }
                    }

                }

                foreach (var trackedPos in sessionData.trackedPositions)
                {
                    if (progressEventPos.ContainsKey("Position Data"))
                        progressEventPos["Position Data"].Add(trackedPos.trackedPosition);
                    else
                        progressEventPos.Add("Position Data", new List<Vector3>());
                }
            }

            // for position data
            progressEventNames.Add("Position Data", false);

        }
        /// <summary>
        /// Sets lowest and highest vector 
        /// </summary>
        Tuple<Vector3, Vector3> setEdgeVectors(List<Vector3> allpositions)
        {
            Vector3 lowestVector = new Vector3(float.MaxValue, 0, float.MaxValue);
            Vector3 highestVector = new Vector3(float.MinValue, 0, float.MinValue);

            foreach (var vector3 in allpositions)
            {
                //getting highest and lowest Vector ponts
                if (vector3.x < lowestVector.x)
                    lowestVector.x = vector3.x;
                else if (vector3.x > highestVector.x)
                    highestVector.x = vector3.x;

                if (vector3.z < lowestVector.z)
                    lowestVector.z = vector3.z;
                else if (vector3.z > highestVector.z)
                    highestVector.z = vector3.z;

                if (vector3.y < lowestVector.y)
                    lowestVector.y = vector3.y;
                else if (vector3.y > highestVector.y)
                    highestVector.y = vector3.y;
            }

            return Tuple.Create(highestVector, lowestVector);
        }

        void CheckBounds()
        {
            for (int i = 0; i < heatMapGrid.Keys.Count; i++)
            {
                Bounds bounds = new Bounds(heatMapGrid.Keys.ElementAt(i), sizeSection);
                foreach (var vector3 in progressEventPos[heatMapOptions[chosenHeatMapIndex]])
                {
                    if (bounds.Contains(vector3))
                    {
                        heatMapGrid[heatMapGrid.Keys.ElementAt(i)] = 1 + heatMapGrid[heatMapGrid.Keys.ElementAt(i)];

                    }
                }
            }
        }

        void drawGrid()
        {
            if (heatMapGrid.Keys.Count > 0)
            { 
                foreach (var item in heatMapGrid)
                {

                    if (item.Value >= threshold)
                    {
                     
                        Handles.color = Color.Lerp(startColor, endColor, item.Value / 10f);

                        if (item.Value == 0)
                            Handles.color = startColor;

                        if (drawMesh)
                            Handles.DrawWireCube(item.Key, sizeSection);

                        if (drawSolid)
                            Handles.CubeHandleCap(0, item.Key, Quaternion.LookRotation(Vector3.up), sizeSection.x, EventType.Repaint);
                    }
                }
            }
        }

      
    }
}