using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StairGenerator))]
[CanEditMultipleObjects]
public class StairGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        StairGenerator sg = ((StairGenerator)target);
        DrawDefaultInspector();
        if (GUILayout.Button("Generate"))
        {
            sg.generate();
        }
        if (GUILayout.Button("Checkpoint"))
        {
            sg.startY = sg.nextY;
            sg.startAngle = sg.nextAngle;
        }
    }
}
