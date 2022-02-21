using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PlaytestingTool
{
    public class SettingsWindow : EditorWindow
    {
        [MenuItem("Tools/Visualizers/Tool Settings")]
        static void Init() {
            GetWindow<SettingsWindow>("Tool Settings");
        }

        SerializedObject so;
        private bool uploadData;
        private bool enableSaving;
        private string localFolderPath;
        private string webEndpoint;
        private string pullRequest;

        public Rect windowRect = new Rect(100, 100, 200, 200);

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

            SerializedProperty PullRequestSerilised = so.FindProperty("pullRequest");
            pullRequest = Settings.PULLREQUESTLINK;

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
                webEndpoint = EditorGUILayout.TextField("Server Push Request Enpoint:", Settings.WEBENDPOINT);
                Settings.WEBENDPOINT = webEndpoint;

                pullRequest = EditorGUILayout.TextField("Server Get Request Enpoint:", Settings.PULLREQUESTLINK);
                Settings.PULLREQUESTLINK = pullRequest;
            }
     
            enableSaving = EditorGUILayout.Toggle("Enable Saving", Settings.ENABLE);
            Settings.ENABLE = enableSaving;

            if (GUILayout.Button("Download Data"))
            {
                PlaySessionDataManager.DownloadData();

             /*   VisualizerWindow inst = ScriptableObject.CreateInstance<VisualizerWindow>();
                inst.Show();*/
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
        void DoWindow(int unusedWindowID)
        {
            GUILayout.Button("Hi");
            GUI.DragWindow();
        }

    }
}