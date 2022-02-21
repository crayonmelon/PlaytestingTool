using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytestingTool
{
    [System.Serializable]
    public class SessionData
    {
        public string _id;
        public string SceneName;
        public string UniqueID;
        public string objectName;
        public string sessionName;
        public List<TrackedPosition> trackedPositions;
        public List<TrackedProgressionEvent> trackedProgressions = new List<TrackedProgressionEvent>();
        public List<TrackedStatChange> trackedStatChanges;
        public SessionData()
        {
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

    [System.Serializable]
    public struct TrackedProgressionEvent
    {
        public float timeStamp;
        public string eventName;
        public string value;

        public TrackedProgressionEvent(string eventName, float timeStamp, object value)
        {
            this.eventName = eventName;
            this.timeStamp = timeStamp;
            this.value = value.ToString();
        }

        public TrackedProgressionEvent(string eventName, float timeStamp)
        {
            this.eventName = eventName;
            this.timeStamp = timeStamp;
            this.value = null;
        }
    }

    [System.Serializable]
    public struct TrackedStatChange
    {
        public float timeStamp;
        public float statName;
        public float maxValue;
        public float value;

        public TrackedStatChange(float timeStamp, float statName, float maxValue, float value)
        {
            this.timeStamp = timeStamp;
            this.statName = statName;
            this.maxValue = maxValue;
            this.value = value;
        }
    }
}