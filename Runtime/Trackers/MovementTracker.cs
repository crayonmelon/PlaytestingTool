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
        [Tooltip("How often is the position tracked (0.1 = 0.1second).")]
        [SerializeField] private float stepCount = 0.1f;
        [Tooltip("If true the component will track this specific component\nIf false a field will display to add the object you wish to track.")]
        [SerializeField] bool thisObject = true;
        private List<TrackedPosition> trackedPosition = new List<TrackedPosition>();

        Vector3 prevPos; 

        void Awake()
        {
            if (thisObject) tracking = gameObject.transform;
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
        public void SaveData()
        {
            Debug.Log("DataSaved");
            TrackerManager.SaveMovement(trackedPosition, tracking.name);

        }
    }
}