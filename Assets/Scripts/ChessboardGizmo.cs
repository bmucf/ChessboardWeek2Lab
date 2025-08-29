using UnityEngine;

public class ChessboardGizmo : MonoBehaviour
{
    private Vector3 cubeDimensions = new Vector3(1, 1, 0);
    public Color color1 = new Color(1, 1, 1, 0.82f);
    public Color color2 = new Color(0, 0, 0, 0.82f);

    /// <summary>
    /// The loop didn't work, so I had to write out a line to draw each square.
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.color = color1;
        Gizmos.DrawCube(new Vector3(-3.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-2.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-3.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-2.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-3.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-2.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-3.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-2.5f, -3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, -3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, -3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, -3.5f, 0), cubeDimensions);

        Gizmos.color = color2;
        Gizmos.DrawCube(new Vector3(-2.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-3.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-2.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-3.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-2.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-3.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-2.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-3.5f, -3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, -3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, -3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, -3.5f, 0), cubeDimensions);

        /*for (int i = 0; i < 8; i++)
        {
            transform.Translate(1, 0, 0);
            Gizmos.color = Color.white;
            Gizmos.DrawWireCube(transform.position, cubeDimensions);
        }*/
    }
}