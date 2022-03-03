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
        List<string> choices = new List<string>();
        int dataFlags = 0;

        List<SessionData> ChoosenSessionDataSets = new List<SessionData>();
        Vector2 GUIOverflow;

        [MenuItem("Tools/PlayTesting Tool/Visualisers/Heat Map")]
        static void Init() => GetWindow<HeatMapWindow>("HeatMap Visualiser");

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
                    GUILayout.Label(progressEvent.eventName);
                }
            }
        }

        void DuringSceneGUI(SceneView sceneView)
        {
            foreach (var sessionData in ChoosenSessionDataSets)
            {
                foreach (var progressEvent in sessionData.trackedProgressions)
                {
                    Debug.Log($"Pos {progressEvent.trackedPosition}");
                    Handles.SphereHandleCap(0, progressEvent.trackedPosition, Quaternion.LookRotation(Vector3.up), 2, EventType.Repaint);
                }
            }
        }
    }
}


