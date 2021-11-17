using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlaytestingTool { 
    public class TrackerManager : MonoBehaviour
    {
        [HideInInspector]
        public static PlayerData playerData = new PlayerData();
        private PlayerInfo playerInfo;

        private void Awake()
        {
            playerData.UniqueID = System.Guid.NewGuid().ToString();
            playerData.SceneName = SceneManager.GetActiveScene().name;
        
        }

        internal static void Save()
        {
            JsonManager.SavePlayerDatJson(playerData, playerData.UniqueID);

            //Destroy playerData after save - this might be a bad idea but it also might fix my problems
            playerData = new PlayerData();
        }
    }
}