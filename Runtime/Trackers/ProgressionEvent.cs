using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytestingTool
{
    public static class ProgressionEvent
    {
        /// <summary>
        /// Save Progression point it will be time stamped
        /// </summary>
        /// <param name="name">name saved for progression</param>
        public static void ProgressionTrigger(string name) 
        {
            TrackedProgression trackedProgression = new TrackedProgression(name, Time.realtimeSinceStartup);
            TrackerManager.SaveProgress(trackedProgression);
        }
    }
}