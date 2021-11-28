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
        public List<PlayerData> PlayersData = new List<PlayerData>();
        public List<PlayerData> ChosenPlayersData = new List<PlayerData>();

        public PlayerData playerData;
        List<TrackedPosition> tp;
        string SceneName;

        public List<string> choices = new List<string>();
        public int index = 0;

        GUIStyle lableStyle;
        GUILayoutOption[] SliderStyle;

        bool StyleNotSet = true;
        int flags = 0;

        [MenuItem("Tools/Visualizers/VisualizeMovement")]
        static void Init() => GetWindow<VisualizeMovementEditor>();

        public List<AreaPoints> areaPoints = new List<AreaPoints>();
        SerializedProperty propAreaPoints;


        public int hSliderValue = 0;
        public int leftValue = 0;
        public int rightValue;

        private Color[] colors = new Color[] { Color.blue, Color.red, Color.green, Color.cyan, Color.magenta, Color.yellow, Color.gray, Color.white };

        SerializedObject so;

        void InitStyle()
        {
            StyleNotSet = false;

            lableStyle = new GUIStyle(GUI.skin.label)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 30,
                fontStyle = FontStyle.Bold,

            };

            SliderStyle = new GUILayoutOption[]
            {
                GUILayout.Height(48),
            };
        }

        void OnEnable()
        {
            so = new SerializedObject(this);
            propAreaPoints = so.FindProperty("areaPoints");

            SceneName = EditorSceneManager.GetActiveScene().name;
            GetPlayersData();
            Chosen();

            Selection.selectionChanged += Repaint;
            SceneView.duringSceneGui += this.DuringSceneGUI;
            EditorSceneManager.sceneOpened += SceneChange; 
        }

        void OnDisable()
        {
            Selection.selectionChanged -= Repaint;
            SceneView.duringSceneGui -= this.DuringSceneGUI;
            EditorSceneManager.sceneOpened -= SceneChange;
        }

        public void OnGUI()
        {
            GUILayout.Label("Choose Player Data:");
            GUILayout.Label(SceneName);

            //index = EditorGUILayout.Popup("Player Data",index, choices.ToArray());

            if(choices.Count > 1)
            {
                flags = EditorGUILayout.MaskField("Player Data", flags, choices.ToArray());
                if (GUILayout.Button("Select"))
                    Chosen();
            }
            else
                GUILayout.Label("No Data Collected Yet");

            hSliderValue = Mathf.RoundToInt(GUILayout.HorizontalSlider(hSliderValue, leftValue, rightValue));


            GUILayout.Label("WOWOWOWOW");
            EditorGUILayout.PropertyField(propAreaPoints);

        }

        void Chosen()
        {
            ChosenPlayersData.Clear();

            for (int i = 0; i < PlayersData.Count; i++)
            {
                if ((flags & (1 << i)) == (1 << i)) ChosenPlayersData.Add(PlayersData[i]);
            }

            playerData = JsonManager.LoadPlayerDataJson(choices[index]);
            tp = playerData.trackedPositions;
            SceneView.RepaintAll();
        }

        void DuringSceneGUI(SceneView sceneView)
        {
            if (StyleNotSet) InitStyle();


            drawPath();
            drawAreas();

            SceneView.RepaintAll();
        }

        void drawAreas()
        {
            so.Update();

            for (int i = 0; i < areaPoints.Count; i++)
            {
                areaPoints[i].pointOne = Handles.PositionHandle(areaPoints[i].pointOne, Quaternion.identity);
                areaPoints[i].pointTwo = Handles.PositionHandle(areaPoints[i].pointTwo, Quaternion.identity);

                DrawCube(areaPoints[i].pointOne, areaPoints[i].pointTwo, areaPoints[i].color);

            }

            so.ApplyModifiedProperties();

        }

        void DrawCube(Vector3 pointOne, Vector3 pointTwo, Color color)
        {
            Vector3[] vertsSideOne = new Vector3[]
            {
                new Vector3(pointOne.x, pointOne.y, pointOne.z),
                new Vector3(pointOne.x, pointTwo.y, pointOne.z),
                new Vector3(pointTwo.x, pointTwo.y, pointOne.z),
                new Vector3(pointTwo.x, pointOne.y, pointOne.z),
            };

            Vector3[] vertsSideTwo = new Vector3[]
            {
                new Vector3(pointOne.x, pointOne.y, pointTwo.z),
                new Vector3(pointOne.x, pointTwo.y, pointTwo.z),
                new Vector3(pointTwo.x, pointTwo.y, pointTwo.z),
                new Vector3(pointTwo.x, pointOne.y, pointTwo.z),
            };

            Vector3[] vertsSideThree = new Vector3[]
            {
                new Vector3(pointOne.x, pointOne.y, pointOne.z),
                new Vector3(pointOne.x, pointOne.y, pointTwo.z),
                new Vector3(pointOne.x, pointTwo.y, pointTwo.z),
                new Vector3(pointOne.x, pointTwo.y, pointOne.z),
            };

            Vector3[] vertsSideFour = new Vector3[]
            {
                new Vector3(pointTwo.x, pointOne.y, pointOne.z),
                new Vector3(pointTwo.x, pointOne.y, pointTwo.z),
                new Vector3(pointTwo.x, pointTwo.y, pointTwo.z),
                new Vector3(pointTwo.x, pointTwo.y, pointOne.z),
            };

            Vector3[] vertsSideFive = new Vector3[]
            {
                new Vector3(pointOne.x, pointOne.y, pointOne.z),
                new Vector3(pointOne.x, pointOne.y, pointTwo.z),
                new Vector3(pointTwo.x, pointOne.y, pointTwo.z),
                new Vector3(pointTwo.x, pointOne.y, pointOne.z),
            };

            Vector3[] vertsSideSix = new Vector3[]
            {
                new Vector3(pointOne.x, pointTwo.y, pointOne.z),
                new Vector3(pointOne.x, pointTwo.y, pointTwo.z),
                new Vector3(pointTwo.x, pointTwo.y, pointTwo.z),
                new Vector3(pointTwo.x, pointTwo.y, pointOne.z),
            };

            Handles.DrawSolidRectangleWithOutline(vertsSideOne, color, new Color(color.r,color.g, color.b, 1));
            Handles.DrawSolidRectangleWithOutline(vertsSideTwo, color, new Color(color.r, color.g, color.b, 1));
            Handles.DrawSolidRectangleWithOutline(vertsSideThree, color, new Color(color.r, color.g, color.b, 1));
            Handles.DrawSolidRectangleWithOutline(vertsSideFour, color, new Color(color.r, color.g, color.b, 1));
            Handles.DrawSolidRectangleWithOutline(vertsSideFive, color, new Color(color.r, color.g, color.b, 1));
            Handles.DrawSolidRectangleWithOutline(vertsSideSix, color, new Color(color.r, color.g, color.b, 1));

        }

        void drawPath()
        {
            rightValue = 0;

            for (int k = 0; k < ChosenPlayersData.Count; k++)
            {
                var playerData = ChosenPlayersData[k];
        
                Handles.color = colors[(k + 3) % colors.Length];

                Handles.CubeHandleCap(
                0,
                playerData.trackedPositions[0].trackedPosition,
                Quaternion.LookRotation(Vector3.up),
                1f,
                EventType.Repaint);

                if(rightValue < playerData.trackedPositions.Count)
                {
                    rightValue = playerData.trackedPositions.Count;

                }

                for (int i = 0; i < playerData.trackedPositions.Count; i++)
                {
                    if (i > 0 && i < playerData.trackedPositions.Count)
                    {
                        Handles.DrawLine(playerData.trackedPositions[i - 1].trackedPosition,
                            playerData.trackedPositions[i].trackedPosition, 10);
                    }
                        
                    if (i == hSliderValue)
                    {

                        Handles.CubeHandleCap(0,
                            playerData.trackedPositions[i].trackedPosition,
                            Quaternion.LookRotation(Vector3.up),
                            1f,
                            EventType.Repaint);
                    };
                }

                Handles.CubeHandleCap(
                0,
                playerData.trackedPositions[playerData.trackedPositions.Count - 1].trackedPosition,
                Quaternion.LookRotation(Vector3.up),
                1f,
                EventType.Repaint);
            }
        }

        void SceneChange(Scene scene, OpenSceneMode mode)
        {
            SceneName = scene.name;

            GetPlayersData();
        }

        void GetPlayersData()
        {
            PlayerData playerDataTemp;
            string path = "./Assets/PlayerData/";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string[] allFiles = Directory.GetFiles("./Assets/PlayerData", "*.json");

            PlayersData.Clear();
            ChosenPlayersData.Clear();
            choices.Clear();

            foreach (string file in allFiles)
            {
                Debug.Log(file);
                file.Contains(SceneName);
                playerDataTemp = JsonManager.LoadPlayerDataJson(Path.GetFileName(file));

                if(playerDataTemp.SceneName == SceneName)
                {
                    choices.Add(Path.GetFileName(file));
                    PlayersData.Add(playerDataTemp);
                }


            }
        }

        void Reset()
        {
            areaPoints = new List<AreaPoints>() { new AreaPoints() };

        }
    }

    [System.Serializable]
    public class AreaPoints
    {
        [SerializeField]
        public Vector3 pointOne;

        [SerializeField]
        public Vector3 pointTwo;

        [SerializeField]
        public Color color = new Color(0.5f, 0.5f, 0.5f, 0.1f);
    }
}