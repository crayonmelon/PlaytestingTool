using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlaytestingTool { 
    public class TrackerManager : MonoBehaviour
    {
        
        [HideInInspector]
        public static SessionData playerData = new SessionData();

        private void Awake()
        {
            playerData.UniqueID = System.Guid.NewGuid().ToString();
            playerData.SceneName = SceneManager.GetActiveScene().name;
            playerData.PlayerName = $"Player-{playerData.UniqueID.Substring(0, 4)}";
        }

        internal static void Save()
        {
            PlaySessionDataManager.SavePlayerDatJson(playerData, playerData.PlayerName);

            //Destroy playerData after save - this might be a bad idea but it also might fix my problems
            playerData = new SessionData();
        }

        internal static void SaveProgress(TrackedProgressionEvent trackedProgression)
        {
            playerData.trackedProgressions.Add(trackedProgression);
        }

        internal static void SaveStat(TrackedStatChange trackedStatChange)
        {
            playerData.trackedStatChanges.Add(trackedStatChange);
        }
    }
}