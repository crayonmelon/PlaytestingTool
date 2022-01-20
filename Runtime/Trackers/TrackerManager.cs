using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlaytestingTool { 
    public class TrackerManager : MonoBehaviour
    {
        [HideInInspector]
        public static List<SessionData> playerData = new List<SessionData>();

        [HideInInspector]
        public static string sessionName;

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
            sessionName = System.Guid.NewGuid().ToString();
        }

        internal static void SaveMovement(List<TrackedPosition> trackedPosition, string objectName)
        {
            SessionData sessionData = new SessionData();
            sessionData.trackedPositions = trackedPosition;
            sessionData.objectName = objectName;
            sessionData.sessionName = sessionName;
            sessionData.SceneName = SceneManager.GetActiveScene().name;

            PlaySessionDataManager.SavePlayerDatJson(sessionData);
        }

        internal static void SaveProgress(TrackedProgressionEvent trackedProgression)
        {
           //TODO playerData.trackedProgressions.Add(trackedProgression);
        }

        internal static void SaveStat(TrackedStatChange trackedStatChange)
        {
            //TODO playerData.trackedStatChanges.Add(trackedStatChange);
        }
    }
}