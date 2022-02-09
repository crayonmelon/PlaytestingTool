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

        SerializedObject so;
        private bool uploadData;
        private bool enableSaving;
        private string localFolderPath;
        private string webEndpoint;

        void OnEnable()
        {
            so = new SerializedObject(this);

            Settings.LoadSettings();

            SerializedProperty EnableSavingSerilised = so.FindProperty("enableSaving");
            enableSaving = Settings.ENABLE;
            SerializedProperty uploadDataSerilised = so.FindProperty("uploadData");
            uploadData = Settings.UPLOADDATA;

            SerializedProperty FolderPathSerilised = so.FindProperty("localFolderPath");
            localFolderPath = Settings.FOLDERPATH;

            Debug.Log(localFolderPath);

            SerializedProperty WebEndPointSerilised = so.FindProperty("webEndpoint");
            webEndpoint = Settings.WEBENDPOINT;

            Selection.selectionChanged += Repaint;
        }

        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
        }

        private void OnGUI()
        {
            GUILayout.Label("Settings");

            localFolderPath = EditorGUILayout.TextField("Local Folder Path:", Settings.FOLDERPATH);
            Settings.FOLDERPATH = localFolderPath;

            uploadData = EditorGUILayout.Toggle("Upload Data", Settings.UPLOADDATA);
            Settings.UPLOADDATA = uploadData;
            

            if (Settings.UPLOADDATA)
            {
                webEndpoint = EditorGUILayout.TextField("Server Enpoint:", Settings.WEBENDPOINT);
                Settings.WEBENDPOINT = webEndpoint;

                if (GUILayout.Button("Upload Data"))
                {
                  //  SessionData sessionData = PlaySessionDataManager.LoadPlayerDataJson("24-01-22 PlaySession a5df/SessionData FPSController0.json");
                 //   PlaySessionDataManager.UploadSessionData("24-01-22 PlaySession a5df","24-01-22 PlaySession a5df/SessionData FPSController0.json");
                }

     
            }
            enableSaving = EditorGUILayout.Toggle("Enable Saving", Settings.ENABLE);
            Settings.ENABLE = enableSaving;

            if (GUILayout.Button("Download Data"))
            {
                PlaySessionDataManager.DownloadData();
            }

            if (GUILayout.Button("Save Settings"))
            {
                Settings.SaveSettings();
            }

            if (GUILayout.Button("Load Settings"))
            {
                Settings.LoadSettings();
            }

        }

    }
}