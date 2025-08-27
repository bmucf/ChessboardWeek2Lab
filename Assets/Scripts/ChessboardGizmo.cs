using UnityEngine;

public class ChessboardGizmo : MonoBehaviour
{
    private Vector3 cubeDimensions = new Vector3(1,1,0);

    /// <summary>
    /// The loop didn't work, so I had to write out a line to draw each square.
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.color = Color.antiqueWhite;
        Gizmos.DrawCube(new Vector3(-3.5f,3.5f,0), cubeDimensions);
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

        Gizmos.color = Color.darkOliveGreen;
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