using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlaytestingTool { 
    public class TrackerManager : MonoBehaviour
    {
        [HideInInspector]
        public static List<SessionData> SessionDataCollection = new List<SessionData>();

        [HideInInspector]
        public static string sessionName = null;

        //[HideInInspector]
        //public static float startingTime;

        static string progressionData = "progressionData";

        private void OnEnable()
        {
            DontDestroyOnLoad(this.gameObject);

            Settings.LoadSettings();

            if (sessionName == null)
                sessionName = System.Guid.NewGuid().ToString();
        }

        internal static void SaveMovement(List<TrackedPosition> trackedPosition, string objectName)
        {
            int thisObjectNameCount = 0;

            foreach (var session in SessionDataCollection)
            {
                if (session.objectName.Contains(objectName))
                {
                    thisObjectNameCount++;
                }
            }

            SessionData sessionData = new SessionData();
            sessionData.trackedPositions = trackedPosition;
            sessionData.objectName = objectName + thisObjectNameCount.ToString();
            sessionData.sessionName = sessionName;
            sessionData.SceneName = SceneManager.GetActiveScene().name;

            SessionDataCollection.Add(sessionData);
        }

        static int GetSessionDataPos()
        {
            for (int i = 0; i < SessionDataCollection.Count; i++)
            {
                SessionData sessionData = SessionDataCollection[i];
                if (sessionData.objectName == progressionData && sessionData.SceneName == SceneManager.GetActiveScene().name)
                {
                    return i;
                }
            }

            SessionData newSessionData = new SessionData();
            newSessionData.objectName = progressionData;
            newSessionData.sessionName = sessionName;
            newSessionData.SceneName = SceneManager.GetActiveScene().name;
            SessionDataCollection.Add(newSessionData);
            return SessionDataCollection.IndexOf(newSessionData);
        }

        internal static void SaveProgress(TrackedProgressionEvent trackedProgression)
        {
            int dataindex = GetSessionDataPos();
            Debug.Log(SessionDataCollection[dataindex]);
            SessionDataCollection[dataindex].trackedProgressions.Add(trackedProgression);
        }

        internal static void SaveStat(TrackedStatChange trackedStatChange)
        {
            //TODO playerData.trackedStatChanges.Add(trackedStatChange);
        }

        void OnDestroy()
        {
            saveData();
        }

        public void saveData()
        {
            Debug.Log($"size of SessionDataCollection {SessionDataCollection.Count}");
            foreach (var sessionData in SessionDataCollection)
            {
                Debug.Log("New FileSaved " + sessionData.objectName + "SceneName " + sessionData.sessionName);
                Debug.Log($"Name: {sessionData.objectName}");

                sessionData.UniqueID = System.Guid.NewGuid().ToString();
                sessionData.dateCreated = $"{System.DateTime.Now:dd-MM-yy}";

                PlaySessionDataManager.SavePlayerDatJson(sessionData);

                if (Settings.UPLOADDATA)
                {
                    Debug.Log("Uploading Data...");
                    PlaySessionDataManager.UploadSessionData(sessionData);
                }
            }
        }
    }
}