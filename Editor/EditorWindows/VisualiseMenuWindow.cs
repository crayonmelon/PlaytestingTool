using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PlaytestingTool
{
    public class VisualiseMenuWindow : EditorWindow
    {
        [MenuItem("Tools/PlayTesting Tool/Visualiser Menu")]

        static void Init() => GetWindow<VisualiseMenuWindow>("Visualiser Menu");

        void Start() {}

        public void OnGUI()
        {
            GUILayout.Label("Choose Visualisation Type");

            if (GUILayout.Button("Drawn Path"))
            {

                PathVisualiserWindow inst = GetWindow<PathVisualiserWindow>("Path Visualiser");
                inst.Show();

            }

            if (GUILayout.Button("Drawn Heat Map"))
            {
                HeatMapWindow inst = GetWindow<HeatMapWindow>("HeatMap Visualiser");
                inst.Show();
            }

            if (GUILayout.Button("Draw Time Line"))
            {
                Debug.Log("not done yet snake");
            }
        }
    }
}
