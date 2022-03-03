using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

namespace PlaytestingTool
{
    public class TimeLineWindow : EditorWindow
    {
        List<string> choices = new List<string>();
        int dataFlags = 0;

        List<SessionData> ChoosenSessionDataSets = new List<SessionData>();
        Vector2 GUIOverflow;

        [MenuItem("Tools/PlayTesting Tool/Visualisers/Time Line")]
        static void Init() => GetWindow<TimeLineWindow>("Time Line Visualiser");

        private void OnEnable()
        {
            RefreshData();
        }
        void OnFocus()
        {
            RefreshData();
        }

        public void RefreshData()
        {
            choices = GetSessionDataLib.GetSessionDataChoices(false);
        }

        private void OnGUI()
        {
            GUILayout.Label("Choose Player Data:");

            if (choices.Count >= 1)
            {
                dataFlags = EditorGUILayout.MaskField("Player Data", dataFlags, choices.ToArray());
                if (GUILayout.Button("Select"))
                {
                    ChoosenSessionDataSets = GetSessionDataLib.GetChosenSessionData(choices, dataFlags, false);
                    //  Debug.Log(ChoosenSessionDataSets.Count);
                }
            }

            GUIOverflow = GUILayout.BeginScrollView(GUIOverflow, false, false);
            drawTimeline();
            GUILayout.EndScrollView();

        }

        private void drawTimeline()
        {

            GUILayout.BeginHorizontal("box");
            drawColTimeline();

            foreach (var sessionData in ChoosenSessionDataSets)
            {
                if (sessionData.trackedProgressions.Count <= 0)
                    continue;


                GUILayout.BeginVertical("box", GUILayout.Width(300));
                GUILayout.Label(sessionData.sessionName);

                List<TrackedProgressionEvent> list = sessionData.trackedProgressions.OrderBy(x => x.timeStamp).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    TrackedProgressionEvent progressEvent = list[i];

                    DrawLib.DrawUILine(Color.grey);
                    GUILayout.Label($"{FormatTime(progressEvent.timeStamp)} {progressEvent.eventName}", GUILayout.Height(20));
                }

                GUILayout.EndVertical();
            }
            GUILayout.EndHorizontal();
        }

        private void drawColTimeline()
        {
            GUILayout.BeginVertical("box", GUILayout.Width(30));
            GUILayout.Label($" ", GUILayout.Height(20));

            for (int i = 0; i < 100; i++)
            {
                GUILayout.Label($"{FormatTime(i)}", GUILayout.Height(20));
            }

            GUILayout.EndVertical();
        }

        public string FormatTime(float time)
        {
            int minutes = (int)time / 60;
            int seconds = (int)time - 60 * minutes;
            int milliseconds = (int)(1000 * (time - minutes * 60 - seconds));
            return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        }
    }
}

