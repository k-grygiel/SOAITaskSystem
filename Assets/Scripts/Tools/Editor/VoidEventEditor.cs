using UnityEditor;
using UnityEngine;

namespace Tools
{
    [CustomEditor(typeof(VoidScriptableEvent))]
    public class VoidEventEditor : Editor
    {
        private Vector2 scrollPos;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            var scriptableEvent = target as VoidScriptableEvent;
            if (!EditorApplication.isPlaying || scriptableEvent.Listeners.Count == 0)
                return;

            EditorGUILayout.Space(5);
            EditorGUILayout.LabelField("Event listeners:");
            scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Height(250));
            for (int i = 0; i < scriptableEvent.Listeners.Count; i++)
            {
                var listener = (Object)scriptableEvent.Listeners[i];
                EditorGUILayout.ObjectField(listener, typeof(Object), true, GUILayout.Height(20));
            }
            EditorGUILayout.EndScrollView();
        }
    }
}