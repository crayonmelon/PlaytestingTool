using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytestingTool
{
    public static class ProgressionEvent
    {
        /// <summary>
        /// Saving a progression event to the data, it will be time stamped
        /// </summary>
        /// <param name="eventName">name saved for progression</param>
        /// <param name="value">Serizable value corresponding to the progression event</param>
        public static void ProgressionTrigger(string eventName, object value) 
        {
            TrackedProgressionEvent trackedProgression = new TrackedProgressionEvent(eventName, Time.realtimeSinceStartup, value);
            TrackerManager.SaveProgress(trackedProgression);

        }

        /// <summary>
        /// Saving a progression event to the data, it will be time stamped
        /// </summary>
        /// <param name="eventName">name saved for progression</param>
        public static void ProgressionTrigger(string eventName)
        {
            TrackedProgressionEvent trackedProgression = new TrackedProgressionEvent(eventName, Time.realtimeSinceStartup);
            TrackerManager.SaveProgress(trackedProgression);
        }

        /// <summary>
        /// Saving a progression event to the data, it will be time stamped
        /// </summary>
        /// <param name="position">position the event took place at</param>
        /// <param name="eventName"></param>
        public static void ProgressionTriggerWithPosition(string eventName, Vector3 position, object value = null)
        {
            TrackedProgressionEvent trackedProgression = new TrackedProgressionEvent(eventName, Time.realtimeSinceStartup, position);
            TrackerManager.SaveProgress(trackedProgression);
        }
    }
}