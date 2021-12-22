using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace PlaytestingTool
{
    /// <summary>
    /// A Collection of Calculation functions to be called by VisualizeMovementEditor
    /// </summary>
    public class CalculationLib : Editor
    {
        public static Dictionary<string, int> ContainsVectors(List<TrackedPosition> playerPos, List<AreaPoints> areaPoints)
        {
            Dictionary<string, int> containingPoints = new Dictionary<string, int>();
            foreach (var pos in playerPos)
            {
                string name = "UNKOWN";
                for (int i = 0; i < areaPoints.Count; i++)
                {
                    if (areaPoints[i].areaBounds.Contains(pos.trackedPosition))
                        name = areaPoints[i].name;
                }

                if (containingPoints.ContainsKey(name))
                    containingPoints[name] = containingPoints[name] + 1;
                else
                    containingPoints[name]  = 1;
            }

            return containingPoints;
        }
    }

    [System.Serializable]
    public class AreaPoints
    {
        [SerializeField]
        public Vector3 pointOne;

        [SerializeField]
        public Vector3 pointTwo;

        [SerializeField]
        public Color color;

        [SerializeField]
        public string name;

        [System.NonSerialized]
        public Bounds areaBounds;

        public AreaPoints(Vector3 pointOne, Vector3 pointTwo, Color color, string name, Bounds areaBounds)
        {
            this.pointOne = pointOne;
            this.pointTwo = pointTwo;
            this.color = color;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.areaBounds = areaBounds;
        }
    }
}

