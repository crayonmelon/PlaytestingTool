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
        }

        void OnFocus()
        {
            choices = GetSessionDataLib.GetSessionDataChoices(true);
        }


        private void OnGUI()
        {
            GUILayout.BeginVertical("box", GUILayout.Width(300));

            GUILayout.Label("Choose Session Data:");

            if (choices.Count >= 1)
            {
                dataFlags = EditorGUILayout.MaskField("Player Data", dataFlags, choices.ToArray());
                if (GUILayout.Button("Select"))
                {
                    ChoosenSessionDataSets = GetSessionDataLib.GetChosenSessionData(choices, dataFlags, true);
                    //  Debug.Log(ChoosenSessionDataSets.Count);
                    progressEventNames.Clear();
                }
            }
            else
                GUILayout.Label("No Data Collected Yet");

            GUILayout.EndVertical();
                foreach (var sessionData in ChoosenSessionDataSets)
                {
                    foreach (var progressEvent in sessionData.trackedProgressions)
                    {
                        if (!progressEventNames.ContainsKey(progressEvent.eventName))
                        {
                            progressEventNames.Add(progressEvent.eventName, false);
                        }
                    }
                }

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
        }
    }
}