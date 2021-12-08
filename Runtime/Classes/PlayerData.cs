using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytestingTool
{
    [System.Serializable]
    public class PlayerData
    {
        public string SceneName;
        public string UniqueID;
        public List<TrackedPosition> trackedPositions;
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

    [System.Serializable]
    public struct Vector3Data
    {
        public float x, y, z;

        public Vector3Data(float rX, float rY, float rZ)
        {
            x = rX;
            y = rY;
            z = rZ;
        }

        public static implicit operator Vector3(Vector3Data rValue)
        {
            return new Vector3(rValue.x, rValue.y, rValue.z);
        }

        public static implicit operator Vector3Data(Vector3 rValue)
        {
            return new Vector3Data(rValue.x, rValue.y, rValue.z);
        }
    }
}