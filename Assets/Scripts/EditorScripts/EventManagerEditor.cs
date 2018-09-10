using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor

    [CustomEditor(typeof(EventManager))]
public class EventManagerEditorScript : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EventManager manager = (EventManager)target;

        GUILayout.Box("Parameters"); 
        if(GUILayout.Button("Destroy Block"))
        {
            manager.DestroyBlock(); 
        }
    }
}
