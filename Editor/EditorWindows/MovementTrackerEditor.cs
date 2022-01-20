using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PlaytestingTool
{
    [CustomEditor(typeof(MovementTracker))]
    [CanEditMultipleObjects]
    public class MovementTrackerEditor : Editor
    {
        SerializedProperty tracking;
        SerializedProperty stepCount;

        bool showBtn = true;
        private void OnEnable()
        {
            tracking = serializedObject.FindProperty("tracking");
            stepCount = serializedObject.FindProperty("stepCount");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(stepCount);

            showBtn = EditorGUILayout.Toggle("Track This GameObject", showBtn);

            if (!showBtn)
                EditorGUILayout.PropertyField(tracking);

            serializedObject.ApplyModifiedProperties();

        }
    }
}
