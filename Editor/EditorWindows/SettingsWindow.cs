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

            enableSaving = EditorGUILayout.Toggle(new GUIContent("Enable Local Saving","When enables the generated data will be saved locally in the specified folder"), Settings.ENABLE);
            Settings.ENABLE = enableSaving;

            localFolderPath = EditorGUILayout.TextField(new GUIContent("Local Folder Path", "Where the Session Data is saved"), Settings.FOLDERPATH);
            Settings.FOLDERPATH = localFolderPath;

            uploadData = EditorGUILayout.Toggle(new GUIContent("Enable Uploading Data", "When enabled the tool will try to post the SessionData to the specified Endpoint"), Settings.UPLOADDATA);
            Settings.UPLOADDATA = uploadData;
            
            if (Settings.UPLOADDATA)
            {
                webEndpoint = EditorGUILayout.TextField(new GUIContent("Post Request Enpoint:", "the endpoint to which the data is uploaded at the end of the play session."), Settings.WEBENDPOINT);
                Settings.WEBENDPOINT = webEndpoint;

                pullRequest = EditorGUILayout.TextField(new GUIContent("Get Request Enpoint:", "the endpoint to get all data from the database. Is used by the **Download Data Button**."), Settings.PULLREQUESTLINK);
                Settings.PULLREQUESTLINK = pullRequest;

                EditorGUILayout.LabelField(new GUIContent("AuthToken", "Auth token sent in the header of the Post and get requests for Authorisation.") );
                showAuthField = EditorGUILayout.Toggle(new GUIContent("Hide","Hide auth Token"), showAuthField);
                if (!showAuthField)
                {
                    GUIStyle style = new GUIStyle(EditorStyles.textArea);
                    style.wordWrap = true;
                    authToken = EditorGUILayout.TextArea(Settings.AUTHTOKEN, style);
                    Settings.AUTHTOKEN = authToken;
                }
            }
     
            
            if (GUILayout.Button(new GUIContent("Download Data","Downloads all Session Data from the database with the specified get endpoint")))
            {
                PlaySessionDataManager.DownloadData();
            }

            if (GUILayout.Button(new GUIContent("Convert To CSV", "Converts tracked progression JSON file Data to a CSV file")))
            {
                ConvertToCSVWindow inst = GetWindow<ConvertToCSVWindow>("Convert To CSV", typeof(ConvertToCSVWindow));
                inst.Show();
            }

            GUILayout.FlexibleSpace();

            if (GUILayout.Button(new GUIContent("Save Settings", "Save the settings set in the tool. Settings settings are saved as a JSON file at Assets/Settings/settingsData.json")))
            {
                Settings.SaveSettings();
            }

            if (GUILayout.Button(new GUIContent("Load Settings", "load settings from Assets/Settings/settingsData.json")))
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