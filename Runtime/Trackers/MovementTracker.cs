using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PlaytestingTool
{
    [AddComponentMenu("Playtesting/MovementTracker")]
    public class MovementTracker : MonoBehaviour
    {
        [SerializeField] private Transform tracking;
        [SerializeField] private float stepCount;
        private List<TrackedPosition> trackedPosition = new List<TrackedPosition>();

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

        private void OnDisable() => SaveData();
        public void SaveData() => TrackerManager.SaveMovement(trackedPosition, tracking.name);
    }

    [System.Serializable]
    public struct TrackedPosition
    {
        public Vector3Data trackedPosition;
        public float timeStamp;

        public TrackedPosition(Vector3Data tp, float tt)
        {
            trackedPosition = tp;
            timeStamp = tt;
        }
    }
}