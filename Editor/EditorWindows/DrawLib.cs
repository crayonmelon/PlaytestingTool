using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PlaytestingTool
{
    /// <summary>
    /// A Collection of Draw voids for drawing in the scene
    /// Used by VisualizeMovementEditor
    /// </summary>
    public class DrawLib : Editor
    {
        static public Color[] colors = new Color[] { Color.blue, Color.red, Color.green, Color.cyan, Color.magenta, Color.yellow, Color.gray, Color.white };

        /// <summary>
        /// Draws cubed areas sizes defined bu area points 
        /// </summary>
        /// <param name="areaPoints">contains size and location</param>
        /// <param name="serializedObject">for updating the scene</param>
        public static void DrawAreas(List<AreaPoints> areaPoints, SerializedObject serializedObject)
        {
            serializedObject.Update();

            for (int i = 0; i < areaPoints.Count; i++)
            {
                areaPoints[i].pointOne = Handles.PositionHandle(areaPoints[i].pointOne, Quaternion.identity);
                areaPoints[i].pointTwo = Handles.PositionHandle(areaPoints[i].pointTwo, Quaternion.identity);

                Vector3 CenterVector = Vector3.Lerp(areaPoints[i].pointOne, areaPoints[i].pointTwo, 0.5f);
                Vector3 size = new Vector3(Mathf.Abs(areaPoints[i].pointOne.x - areaPoints[i].pointTwo.x), Mathf.Abs(areaPoints[i].pointOne.y - areaPoints[i].pointTwo.y), Mathf.Abs(areaPoints[i].pointOne.z - areaPoints[i].pointTwo.z));

                Handles.color = areaPoints[i].color;
                Handles.DrawWireCube(CenterVector, size);

                areaPoints[i].areaBounds = new Bounds(CenterVector, size);
            }

            serializedObject.ApplyModifiedProperties();
        }


        /// <summary>
        /// Drawing the Path the player took
        /// </summary>
        /// <param name="rightValue"></param>
        /// <param name="hSliderValue"></param>
        /// <param name="chosenPlayersData"></param>
        public static void drawPath(int rightValue,int hSliderValue, List<PlayerData> chosenPlayersData)
        {
            rightValue = 0;

            for (int k = 0; k < chosenPlayersData.Count; k++)
            {
                var playerData = chosenPlayersData[k];

                if(playerData.trackedPositions == null || playerData.trackedPositions.Count == 0)
                {
                    continue;
                }

                Handles.color = colors[(k + 3) % colors.Length];

                Handles.CubeHandleCap(
                0,
                playerData.trackedPositions[0].trackedPosition,
                Quaternion.LookRotation(Vector3.up),
                1f,
                EventType.Repaint);

                if (rightValue < playerData.trackedPositions.Count)
                {
                    rightValue = playerData.trackedPositions.Count;

                }

                for (int i = 0; i < playerData.trackedPositions.Count; i++)
                {
                    if (i > 0 && i < playerData.trackedPositions.Count)
                    {
                        Handles.DrawAAPolyLine(playerData.trackedPositions[i - 1].trackedPosition,
                            playerData.trackedPositions[i].trackedPosition);
                    }

                    if (i == hSliderValue)
                    {
                        Handles.CubeHandleCap(0,
                            playerData.trackedPositions[i].trackedPosition,
                            Quaternion.LookRotation(Vector3.up),
                            1f,
                            EventType.Repaint);
                    };

                    foreach (var progression in playerData.trackedProgressions)
                    {
                        if (progression.timeStamp > playerData.trackedPositions[i].timeStamp && progression.timeStamp < playerData.trackedPositions[i+1].timeStamp)
                        {
                            Handles.SphereHandleCap(
                            0,
                            playerData.trackedPositions[i].trackedPosition,
                            Quaternion.LookRotation(Vector3.up),
                            1f,
                            EventType.Repaint);

                            Handles.Label( playerData.trackedPositions[i].trackedPosition + Vector3.up*2, progression.eventName);
                        }
                    }
          
                }

                Handles.CubeHandleCap(
                0,
                playerData.trackedPositions[playerData.trackedPositions.Count - 1].trackedPosition,
                Quaternion.LookRotation(Vector3.up),
                1f,
                EventType.Repaint);
            }
        }

        public static void DrawUILine(Color color, int thickness = 2, int padding = 10)
        {
            Rect r = EditorGUILayout.GetControlRect(GUILayout.Height(padding + thickness));
            r.height = thickness;
            r.y += padding / 2;
            r.x -= 2;
            r.width += 6;
            EditorGUI.DrawRect(r, color);
        }
    }
}