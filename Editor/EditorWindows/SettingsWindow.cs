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
            Settings.WEBENDPOINT = EditorGUILayout.TextField("Server Enpoint:", Settings.WEBENDPOINT);

            Debug.Log(Settings.FOLDERPATH);
        }
    }
}
