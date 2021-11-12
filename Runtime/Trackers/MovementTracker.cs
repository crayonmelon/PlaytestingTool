using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PlaytestingTool
{
    [RequireComponent(typeof(TrackerManager)), AddComponentMenu("Playtesting/MovementTracker")]
    public class MovementTracker : MonoBehaviour
    {
        [SerializeField] private Transform tracking;
        [SerializeField] private float stepCount;
        private List<TrackedPosition> trackedPosition => TrackerManager.playerData.trackedPositions;

        void Awake()
        {
            if (tracking == null) tracking = gameObject.transform;
        }

        void Start() => StartCoroutine(addNewPos(tracking, stepCount));

        private IEnumerator addNewPos(Transform tracking, float step)
        {
            while (true)
            {
                yield return new WaitForSeconds(step);
                TrackedPosition trackerClass = new TrackedPosition(tracking.position, Time.realtimeSinceStartup);
                trackedPosition.Add(trackerClass);
            }
        }

        private void OnDisable() => TrackerManager.Save();
    }

    [System.Serializable]
    public class TrackedPosition
    {
        public Vector3 trackedPosition;
        public float timeStamp;

        public TrackedPosition(Vector3 tp, float tt)
        {
            trackedPosition = tp;
            timeStamp = tt;
        }
    }
}