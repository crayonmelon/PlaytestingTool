using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PlaytestingTool
{
    public class SettingsWindow : EditorWindow
    {
        [MenuItem("Tools/Visualizers/Tool Settings")]
        static void Init() => GetWindow<SettingsWindow>("Tool Settings");

        void OnEnable()
        {
            Selection.selectionChanged += Repaint;
        }

        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
        }

        private void OnGUI()
        {
            GUILayout.Label("Settings");

            Settings.FOLDERPATH = EditorGUILayout.TextField("Local Folder Path:", Settings.FOLDERPATH);
            Settings.UPLOADDATA = EditorGUILayout.Toggle("Upload Data", Settings.UPLOADDATA);

            if (Settings.UPLOADDATA)
            {
                Settings.WEBENDPOINT = EditorGUILayout.TextField("Server Enpoint:", Settings.WEBENDPOINT);

                if (GUILayout.Button("Upload Data"))
                {
                  //  SessionData sessionData = PlaySessionDataManager.LoadPlayerDataJson("24-01-22 PlaySession a5df/SessionData FPSController0.json");
                    PlaySessionDataManager.UploadSessionData("24-01-22 PlaySession a5df/SessionData FPSController0.json");
                }
            }

            Settings.ENABLE = EditorGUILayout.Toggle("Enable Saving", Settings.ENABLE);

            Debug.Log(Settings.FOLDERPATH);
        }
    }
}