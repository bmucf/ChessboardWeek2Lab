using JetBrains.Annotations;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

public class ChesspieceGizmo : MonoBehaviour
{
    public enum Pieces //creates dropdown menu in inspector
    {
        Pawn,
        Bishop,
        Knight,
        Rook,
        Queen,
        King
    }

    public Pieces selectedPiece;

    Dictionary<Pieces, string> PieceIconSelect = new Dictionary<Pieces, string>() //binds dropdown menu options to icon files
    {
        {Pieces.Pawn, "Chess_plt60.png"},
        {Pieces.Bishop, "Chess_blt60.png"},
        {Pieces.Knight, "Chess_nlt60.png"},
        {Pieces.Rook, "Chess_rlt60.png"},
        {Pieces.Queen, "Chess_qlt60.png"},
        {Pieces.King, "Chess_klt60.png"},
    };

    public Color iconColor = new Color(1f, 1f, 1f);
    Vector3[] moves;

    void OnDrawGizmos()
    {


        if (PieceIconSelect.TryGetValue(selectedPiece, out string iconName))
        {
            Gizmos.DrawIcon(transform.position, iconName, true, iconColor); //draws the chess pieces based on selected value from dropdown
        }
    }

    private void OnDrawGizmosSelected() //draws a path for selected piece
    {
        switch (selectedPiece)
        {
            case Pieces.Pawn:
                moves = new Vector3[2]
                {
                    transform.position,
                    transform.position + new Vector3(0, 1, 0),
                };
                break;
            case Pieces.Bishop:
                moves = new Vector3[8]
                {
                    transform.position,
                    transform.position + new Vector3(7, 7, 0),
                    transform.position,
                    transform.position + new Vector3(-7, -7, 0),
                    transform.position,
                    transform.position + new Vector3(7, -7, 0),
                    transform.position,
                    transform.position + new Vector3(-7, 7, 0),
                };
                break;
            case Pieces.Knight:
                moves = new Vector3[16]
                {
                    transform.position,
                    transform.position + new Vector3(2, 1, 0),
                    transform.position,
                    transform.position + new Vector3(-2, -1, 0),
                    transform.position,
                    transform.position + new Vector3(2, -1, 0),
                    transform.position,
                    transform.position + new Vector3(-2, 1, 0),
                    transform.position,
                    transform.position + new Vector3(1, 2, 0),
                    transform.position,
                    transform.position + new Vector3(-1, -2, 0),
                    transform.position,
                    transform.position + new Vector3(-1, 2, 0),
                    transform.position,
                    transform.position + new Vector3(1, -2, 0),

                };
                break;
            case Pieces.Rook:
                moves = new Vector3[8]
                {
                    transform.position,
                    transform.position + new Vector3(7, 0, 0),
                    transform.position,
                    transform.position + new Vector3(-7, 0, 0),
                    transform.position,
                    transform.position + new Vector3(0, 7, 0),
                    transform.position,
                    transform.position + new Vector3(0, -7, 0),
                };
                break;
            case Pieces.Queen:
                moves = new Vector3[16]
                {
                    transform.position,
                    transform.position + new Vector3(7,7,0),
                    transform.position,
                    transform.position + new Vector3(-7,-7,0),
                    transform.position,
                    transform.position + new Vector3(7,-7,0),
                    transform.position,
                    transform.position + new Vector3(-7, 7, 0),
                    transform.position,
                    transform.position + new Vector3(7,0,0),
                    transform.position,
                    transform.position + new Vector3(-7,0, 0),
                    transform.position,
                    transform.position + new Vector3(0,7,0),
                    transform.position,
                    transform.position + new Vector3(0, -7, 0),
                };
                break;
            case Pieces.King:
                moves = new Vector3[16]
                {
                    transform.position,
                    transform.position + new Vector3(1, 0, 0),
                    transform.position,
                    transform.position + new Vector3(-1, 0, 0),
                    transform.position,
                    transform.position + new Vector3(0, 1, 0),
                    transform.position,
                    transform.position + new Vector3(0, -1, 0),
                    transform.position,
                    transform.position + new Vector3(1, 1, 0),
                    transform.position,
                    transform.position + new Vector3(-1, -1, 0),
                    transform.position,
                    transform.position + new Vector3(1, -1, 0),
                    transform.position,
                    transform.position + new Vector3(-1, 1, 0),
                };
                break;
        }
        Gizmos.color = Color.white;
        Gizmos.DrawLineList(moves);
    }
}

namespace UnityEditor
{
    [CustomEditor(typeof(GameObject))]
    public class CustomInspector : Editor
    {
        public void OnSceneGUI()
        {
            GameObject selectedObject = (GameObject)target;
            

            int controlID = 1;
            Transform transform = selectedObject.transform;
            Vector3 position = transform.position;
            Quaternion rotation = Quaternion.identity;
            float size = 0.45f;
            EventType eventType = EventType.Repaint;
            Handles.color = Color.red;

            // draw the outline with an alpha of 1.0
            if (Event.current.type == EventType.Repaint)
                Handles.DrawSelectionFrame(controlID, position, rotation, size, eventType);
        }
    }
}
