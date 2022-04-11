using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PlaytestingTool
{
    public class ConvertToCSVWindow : EditorWindow
    {
        List<string> choices = new List<string>();
        List<SessionData> ChoosenSessionDataSets = new List<SessionData>();
        int dataFlags = 0;

        [MenuItem("Tools/PlayTesting Tool/ConvertToCSV")]
        static void Init() => GetWindow<ConvertToCSVWindow>("CSV Window");

        private void OnEnable()
        {
            choices = GetSessionDataLib.GetSessionDataChoices(false);
        }

        private void OnGUI()
        {
            
            dataFlags = EditorGUILayout.MaskField("Player Data", dataFlags, choices.ToArray());
            if (GUILayout.Button("Select"))
            {
                ConvertToCSV();
            }

            if(ChoosenSessionDataSets.Count > 0)
            {
                DrawLib.DrawUILine(Color.grey);
                GUILayout.Label($"Created {choices.Count} CSV files");
            }
        }
        private void ConvertToCSV()
        {
            ChoosenSessionDataSets = GetSessionDataLib.GetChosenSessionData(choices, dataFlags, false);

            foreach (var sessionData in ChoosenSessionDataSets)
            {
                PlaySessionDataManager.ConvertToCSV(sessionData);
            }
        }
    }
}