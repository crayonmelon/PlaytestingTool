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
        [SerializeField] private float stepCount = 0.1f;
        private List<TrackedPosition> trackedPosition = new List<TrackedPosition>();

        Vector3 prevPos; 

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

                if (tracking.position != prevPos)
                {
                    TrackedPosition trackerClass = new TrackedPosition(tracking.position, Time.realtimeSinceStartup);
                    trackedPosition.Add(trackerClass);
                }

                prevPos = tracking.position;
            }
        }

        private void OnDisable() => SaveData();
        public void SaveData() => TrackerManager.SaveMovement(trackedPosition, tracking.name);
    }
}