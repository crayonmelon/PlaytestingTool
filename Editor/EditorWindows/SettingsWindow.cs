using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PlaytestingTool
{
    public class SettingsWindow : EditorWindow
    {
        [MenuItem("Tools/PlayTesting Tool/Tool Settings")]
        static void Init() {
            GetWindow<SettingsWindow>("Tool Settings");
        }

        SerializedObject so;
        private bool uploadData;
        private bool enableSaving;
        private string localFolderPath;
        private string webEndpoint;
        private string pullRequest;
        private string authToken;

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

            SerializedProperty WebEndPointSerilised = so.FindProperty("webEndpoint");
            webEndpoint = Settings.WEBENDPOINT;

            SerializedProperty PullRequestSerilised = so.FindProperty("pullRequest");
            pullRequest = Settings.PULLREQUESTLINK;

            SerializedProperty AuthTokenSerilised = so.FindProperty("authToken");
            authToken = Settings.AUTHTOKEN;

            Selection.selectionChanged += Repaint;
        }

        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
        }
        bool showAuthField = true;
        private void OnGUI()
        {
            GUILayout.Label("Settings");

            localFolderPath = EditorGUILayout.TextField("Local Folder Path", Settings.FOLDERPATH);
            Settings.FOLDERPATH = localFolderPath;

            uploadData = EditorGUILayout.Toggle("Enable Uploading Data", Settings.UPLOADDATA);
            Settings.UPLOADDATA = uploadData;
            
            if (Settings.UPLOADDATA)
            {
                webEndpoint = EditorGUILayout.TextField("Push Request Enpoint:", Settings.WEBENDPOINT);
                Settings.WEBENDPOINT = webEndpoint;

                pullRequest = EditorGUILayout.TextField("Get Request Enpoint:", Settings.PULLREQUESTLINK);
                Settings.PULLREQUESTLINK = pullRequest;

                EditorGUILayout.LabelField("AuthToken");
                showAuthField = EditorGUILayout.Toggle("Hide", showAuthField);
                if (!showAuthField)
                {
                    GUIStyle style = new GUIStyle(EditorStyles.textArea);
                    style.wordWrap = true;
                    authToken = EditorGUILayout.TextArea(Settings.AUTHTOKEN, style);
                    Settings.AUTHTOKEN = authToken;
                }
            }
     
            enableSaving = EditorGUILayout.Toggle("Enable Local Saving", Settings.ENABLE);
            Settings.ENABLE = enableSaving;

            if (GUILayout.Button("Download Data"))
            {
                PlaySessionDataManager.DownloadData();

                PopupWindow inst = ScriptableObject.CreateInstance<PopupWindow>();
                inst.Show();
            }

            if (GUILayout.Button("Convert To CSV"))
            {
                ConvertToCSVWindow inst = GetWindow<ConvertToCSVWindow>("Convert To CSV", typeof(ConvertToCSVWindow));
                inst.Show();
            }

            GUILayout.FlexibleSpace();

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