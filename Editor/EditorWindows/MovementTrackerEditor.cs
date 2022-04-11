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
        SerializedProperty thisObject;

        bool showBtn = true;
        private void OnEnable() 
        {
            tracking = serializedObject.FindProperty("tracking");
            stepCount = serializedObject.FindProperty("stepCount");
            thisObject = serializedObject.FindProperty("thisObject");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(stepCount);
            EditorGUILayout.PropertyField(thisObject);

            if (!thisObject.boolValue)
                EditorGUILayout.PropertyField(tracking);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
