using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytestingTool
{
    public class PlayerData
    {
        public List<TrackedPosition> trackedPositions;
        public string SceneName;
        public string UniqueID;
        public List<PlayerInfo> PlayerInfo;

        public PlayerData()
        {
            trackedPositions = new List<TrackedPosition>();
            PlayerInfo = new List<PlayerInfo>();
            SceneName = "not specified";
        }
    }

    [System.Serializable]
    public class PlayerInfo
    {
        public string userName;
        public string feedBack;

        public PlayerInfo(string userName, string feedBack, string iD)
        {
            this.userName = userName;
            this.feedBack = feedBack;
        }
    }
}