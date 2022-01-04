using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PlaytestingTool
{
    [RequireComponent(typeof(TrackerManager)), AddComponentMenu("Playtesting/ProgressionTracker")]
    public class ProgressionTracker : MonoBehaviour
    {
        [SerializeField] UnityEvent progressEvent;
        void Start()
        {
            progressEvent.AddListener(Progression);
            progressEvent.Invoke();

        }

        void Progression()
        {
            Debug.Log("Ping");
            ProgressionEvent.ProgressionTrigger("PlayerReachedBox", 12);
        }
    }
}