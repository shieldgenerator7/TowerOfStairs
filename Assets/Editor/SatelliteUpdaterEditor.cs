using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SatelliteUpdater))]
[CanEditMultipleObjects]
public class SatelliteUpdaterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (GUILayout.Button("Place All"))
        {
            foreach(SatelliteUpdater su in FindObjectsOfType<SatelliteUpdater>())
            {
                su.position();
            }
        }
    }
}
