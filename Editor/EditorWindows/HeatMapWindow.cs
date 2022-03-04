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

        /// <summary>
        /// UI Size
        /// </summary>

        float iconSize;

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
            GUILayout.Label("Choose Player Data:");

            if (choices.Count >= 1)
            {
                dataFlags = EditorGUILayout.MaskField("Player Data", dataFlags, choices.ToArray());
                if (GUILayout.Button("Select"))
                {
                    ChoosenSessionDataSets = GetSessionDataLib.GetChosenSessionData(choices, dataFlags, false);
                    //  Debug.Log(ChoosenSessionDataSets.Count);

                }
            }

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

            for (int i = 0; i < progressEventNames.Keys.Count; i++)
            {
                var eventName = new List<string>(progressEventNames.Keys)[i];
                // string eventName = progressEventNames.Keys.ToList()[i];

                progressEventNames[eventName] = GUILayout.Toggle(progressEventNames[eventName], eventName);
            }

            GUILayout.Label("Icon Size");
            iconSize = GUILayout.HorizontalSlider(iconSize, .1f, 15);
        }

        void DuringSceneGUI(SceneView sceneView)
        {
            foreach (var sessionData in ChoosenSessionDataSets)
            {
                foreach (var progressEvent in sessionData.trackedProgressions)
                {
                    if (progressEventNames.ContainsKey(progressEvent.eventName) && progressEventNames[progressEvent.eventName])
                    {
                        Debug.Log($"Pos {progressEvent.trackedPosition}");
                        Handles.SphereHandleCap(0, progressEvent.trackedPosition, Quaternion.LookRotation(Vector3.up), iconSize, EventType.Repaint);
                    }

                }
            }
        }
    }
}


