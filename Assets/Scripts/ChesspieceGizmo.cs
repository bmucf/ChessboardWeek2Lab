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
        private GameObject[] objects;

        public void OnEnable()
        {
            // Note: If you use FindGameObjectsWithTag in a Prefab Stage that you opened from a Scene,
            // it includes GameObjects from that Scene. Instead use:
            // var renderers = StageUtility.GetCurrentStage().FindComponentsOfType<Renderer>();
            // to explicitly specify where to get the GameObjects from.
            objects = GameObject.FindGameObjectsWithTag("Player");  // populate the objects array with game objects
        }

        public void OnSceneGUI()
        {
            // draw the outline with an alpha of 0.5
            if (Event.current.type == EventType.Repaint)
                Handles.DrawOutline(objects, Color.yellow, Color.green, 0.1f);
        }
    }
}
