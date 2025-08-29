using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

namespace UnityEditor
{
    [CustomEditor(typeof(GameObject))]

    public class OutlineGizmo : Editor
    {
        private GameObject selectedPiece;

        public void OnEnable()
        {
            selectedPiece = (GameObject)target;
        }

        public void OnSceneGUI()
        {
            // draw the outline with an alpha of 0.5
            if (Event.current.type == EventType.Repaint)
                Handles.DrawOutline(selectedPiece, Color.yellow, Color.green, 0.1f);
        }
    }
}