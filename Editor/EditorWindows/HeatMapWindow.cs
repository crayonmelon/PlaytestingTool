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
        List<TrackedProgressionEvent> trackedProgressions = new List<TrackedProgressionEvent>();

        Vector2 GUIOverflow;

        Dictionary<string, bool> progressEventNames = new Dictionary<string, bool>();

        Vector3Int resolution = new Vector3Int(20, 1, 20);
        int threshold = 1;

        [MenuItem("Tools/PlayTesting Tool/Visualisers/Heat Map")]
        static void Init() => GetWindow<HeatMapWindow>("HeatMap Visualiser");

        //SerializedObjects 
        SerializedObject so;
        float iconSize = 1;

        private void OnEnable()
        {
            choices = GetSessionDataLib.GetSessionDataChoices(true);
            Selection.selectionChanged += Repaint;
            SceneView.duringSceneGui += this.DuringSceneGUI;
        }

        private void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
            SceneView.duringSceneGui -= this.DuringSceneGUI;
        }

        void OnFocus()
        {
            SceneView.duringSceneGui -= this.DuringSceneGUI;
            SceneView.duringSceneGui += this.DuringSceneGUI;
            choices = GetSessionDataLib.GetSessionDataChoices(true);
        }

        Vector3 lowestVector;
        Vector3 highestVector;
        private void OnGUI()
        {
            GUILayout.BeginVertical("box", GUILayout.Width(300));
            GUILayout.Label("Choose Session Data:");

            if (choices.Count >= 1)
            {
                dataFlags = EditorGUILayout.MaskField("Player Data", dataFlags, choices.ToArray());
                if (GUILayout.Button("Select"))
                {
                    GetChosenData();
                    InitHeatMapGrid(resolution, highestVector, lowestVector);
                    CheckBounds();
                }
            }
            else
                GUILayout.Label("No Data Collected Yet");

            if (progressEventNames.Count > 0)
            {
                for (int i = 0; i < progressEventNames.Keys.Count; i++)
                {
                    var eventName = new List<string>(progressEventNames.Keys)[i];
                    // string eventName = progressEventNames.Keys.ToList()[i];
                    progressEventNames[eventName] = GUILayout.Toggle(progressEventNames[eventName], eventName);
                }

                GUILayout.Label("Icon Size");
                iconSize = GUILayout.HorizontalSlider(iconSize, .1f, 15,GUILayout.Width(300));

            }

            GUILayout.Label("Grid Resolution");
            
            threshold = (int)EditorGUILayout.Slider("threshold", threshold, 0, 10);

            resolution.x = (int)EditorGUILayout.Slider("resolutionX",resolution.x, 1, 100);
            resolution.y = (int)EditorGUILayout.Slider("resolutionY",resolution.y, 1, 100);
            resolution.z = (int)EditorGUILayout.Slider("resolutionZ",resolution.z, 1, 100);


            GUILayout.EndVertical();
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

        Dictionary<Vector3, int> heatMapGrid = new Dictionary<Vector3, int>();
        Vector3 sizeSection;
        void InitHeatMapGrid(Vector3Int resolution, Vector3 startPos, Vector3 endPos)
        {
            Debug.Log($"{startPos} {endPos}");
            heatMapGrid.Clear();

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

                        Handles.color = Color.red;
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
            progressEventNames.Clear();
            trackedProgressions.Clear();

            lowestVector = new Vector3(float.MaxValue, 0, float.MaxValue);
            highestVector = new Vector3(float.MinValue, 0, float.MinValue);

            foreach (var sessionData in ChoosenSessionDataSets)
            {
                foreach (var progressEvent in sessionData.trackedProgressions)
                {
                    if (!progressEventNames.ContainsKey(progressEvent.eventName))
                        progressEventNames.Add(progressEvent.eventName, false);

                    //getting highest and lowest Vector ponts
                    if (progressEvent.trackedPosition.x < lowestVector.x)
                        lowestVector.x = progressEvent.trackedPosition.x;
                    else if (progressEvent.trackedPosition.x > highestVector.x)
                        highestVector.x = progressEvent.trackedPosition.x;

                    if (progressEvent.trackedPosition.z < lowestVector.z)
                        lowestVector.z = progressEvent.trackedPosition.z;
                    else if (progressEvent.trackedPosition.z > highestVector.z)
                        highestVector.z = progressEvent.trackedPosition.z;

                    if (progressEvent.trackedPosition.y < lowestVector.y)
                        lowestVector.y = progressEvent.trackedPosition.y;
                    else if (progressEvent.trackedPosition.y > highestVector.y)
                        highestVector.y = progressEvent.trackedPosition.y;

                    trackedProgressions.Add(progressEvent);
                }
            }
        }

        void CheckBounds()
        {
            for (int i = 0; i < heatMapGrid.Keys.Count; i++)
            {

                foreach (var sessionData in ChoosenSessionDataSets)
                {
                    foreach (var progressEvent in sessionData.trackedProgressions)
                    {
                       // if (progressEventNames.ContainsKey(progressEvent.eventName) && progressEventNames[progressEvent.eventName])
                        //{
                        Bounds bounds = new Bounds(heatMapGrid.Keys.ElementAt(i), sizeSection);

                        if (bounds.Contains(progressEvent.trackedPosition))
                        {
                            Debug.Log("INSIDE");
                            heatMapGrid[heatMapGrid.Keys.ElementAt(i)] = 1 + heatMapGrid[heatMapGrid.Keys.ElementAt(i)];
                            
                        }
                        //}
                    }
                }
            }
        }

        void drawGrid()
        {
            foreach (var item in heatMapGrid)
            {
                if (item.Value >= threshold)
                {
                  
                    Handles.color = new Color(item.Value / 5f, 0, 0, 1);
                    Handles.DrawWireCube(item.Key, sizeSection);

                /*    if (item.Value >= 3)
                    {
                        Handles.color = Color.red;
                    }
                    else if (item.Value >= 2)
                    {
                        Handles.color = Color.blue;
                        Handles.DrawWireCube(item.Key, sizeSection);
                    }

                    else if (item.Value >= 1)
                    {
                        Handles.color = Color.yellow;
                        Handles.DrawWireCube(item.Key, sizeSection);
                    }
                    else
                    {
                        Handles.color = Color.yellow;
                        Handles.DrawWireCube(item.Key, sizeSection);
                    }*/
                }
            }
        }

    }
}