using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

public enum Pieces
{
    Pawn,
    Bishop,
    Knight,
    Rook,
    Queen,
    King
}

public class ChesspieceGizmo : MonoBehaviour

{
    public Pieces selectedPiece;

    Dictionary<string, string> PieceIconSelect = new Dictionary<string, string>()
    {
        {"Pawn", "Chess_plt60.png"},
        {"Bishop", "Chess_blt60.png"},
        {"Knight", "Chess_nlt60.png"},
        {"Rook", "Chess_rlt60.png"},
        {"Queen", "Chess_qlt60.png"},
        {"King", "Chess_klt60.png"},
    };

    void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "{selectedPiece}", true);
        Debug.Log(selectedPiece);
    }
}
