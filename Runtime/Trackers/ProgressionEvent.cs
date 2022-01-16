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
        /// <param name="name">name saved for progression</param>
        /// <param name="value">Serizable value corresponding to the progression event</param>
        public static void ProgressionTrigger(string name, object value) 
        {
            TrackedProgressionEvent trackedProgression = new TrackedProgressionEvent(name, Time.realtimeSinceStartup, value);
            TrackerManager.SaveProgress(trackedProgression);
        }

        /// <summary>
        /// Saving a progression event to the data, it will be time stamped
        /// </summary>
        /// <param name="name">name saved for progression</param>
        public static void ProgressionTrigger(string name)
        {
            TrackedProgressionEvent trackedProgression = new TrackedProgressionEvent(name, Time.realtimeSinceStartup);
            TrackerManager.SaveProgress(trackedProgression);
        }
    }
}