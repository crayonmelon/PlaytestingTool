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
        /// <param name="eventName">custom name of the progress event<param>
        /// <param name="value">value corresponding to the progression event</param>
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
        /// <param name="position">vector3 position of where the event took place</param>
        /// <param name="eventName">custom name of the progress event</param>
        public static void ProgressionTriggerWithPosition(string eventName, Vector3 position, object value = null)
        {
            TrackedProgressionEvent trackedProgression = new TrackedProgressionEvent(eventName, Time.realtimeSinceStartup, position);
            TrackerManager.SaveProgress(trackedProgression);
        }
    }
}