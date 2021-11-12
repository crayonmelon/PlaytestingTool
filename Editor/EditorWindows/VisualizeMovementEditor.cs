using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

namespace PlaytestingTool
{
    public class VisualizeMovementEditor : EditorWindow
    {
        public PlayerData playerData;
        List<TrackedPosition> tp;
        string SceneName;

        public List<string> choices = new List<string>();
        public int index = 0;

        GUIStyle lableStyle;
        bool StyleNotSet = true;


        [MenuItem("Tools/Visualizers/VisualizeMovement")]
        static void Init() => GetWindow<VisualizeMovementEditor>();
        void InitStyle()
        {
            StyleNotSet = false;

            Debug.Log("style");
            lableStyle = new GUIStyle(GUI.skin.label)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 30,
                fontStyle = FontStyle.Bold,

            };
        }

        void OnEnable()
        {
            GetPlayersData();
            Chosen();

            Selection.selectionChanged += Repaint;
            SceneView.duringSceneGui += this.DuringSceneGUI;
            EditorSceneManager.activeSceneChangedInEditMode += SceneChange;
        }
        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
            SceneView.duringSceneGui -= this.DuringSceneGUI;
            EditorSceneManager.activeSceneChangedInEditMode -= SceneChange;

        }

        public void OnGUI()
        {
            GUILayout.Label("Choose Player Data:");

            GUILayout.Label(SceneName);
            index = EditorGUILayout.Popup(index, choices.ToArray());

            if (GUILayout.Button("Select"))
                Chosen();

        }

        void Chosen()
        {
            playerData = JsonManager.LoadPlayerDataJson(choices[index]);
            tp = playerData.trackedPositions;
            SceneView.RepaintAll();
        }


        void DuringSceneGUI(SceneView sceneView)
        {
            if (StyleNotSet) InitStyle();

            Handles.Label(tp[0].trackedPosition, "STARTED", lableStyle);

            Handles.color = new Color(1, 1f, 0.4f, 1);
            for (int i = 0; i < tp.Count; i++)
            {
                if (i > 0 && i < tp.Count)
                {
                    Handles.DrawLine(tp[i - 1].trackedPosition, tp[i].trackedPosition, 10);
                }
            }

            Handles.Label(tp[tp.Count - 1].trackedPosition, "END", lableStyle);
        }

        void SceneChange(Scene current, Scene next)
        {

            SceneName = next.name;
            GetPlayersData();
        }

        void GetPlayersData()
        {
            string[] allFiles = Directory.GetFiles("./Assets/PlayerData", "*.json");
            foreach (string file in allFiles)
                choices.Add(Path.GetFileName(file));

            choices.Reverse();
        }
    }

}