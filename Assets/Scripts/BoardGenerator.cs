using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    public Vector3 cubeDimensions = Vector3.one;

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 1, 1, 0.5f);

        //first row - white
        Gizmos.DrawCube(new Vector3(-3.5f,3.5f,0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, 3.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, 3.5f, 0), cubeDimensions);

        //second row - white
        Gizmos.DrawCube(new Vector3(-2.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, 2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, 2.5f, 0), cubeDimensions);

        //third row - white
        Gizmos.DrawCube(new Vector3(-3.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, 1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, 1.5f, 0), cubeDimensions);

        //fourth row - white
        Gizmos.DrawCube(new Vector3(-2.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, 0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, 0.5f, 0), cubeDimensions);

        //fifth row - white
        Gizmos.DrawCube(new Vector3(-2.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, -0.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, -0.5f, 0), cubeDimensions);

        //sixth row - white
        Gizmos.DrawCube(new Vector3(-3.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-1.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(0.5f, -1.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(2.5f, -1.5f, 0), cubeDimensions);
        //third row - white
        Gizmos.DrawCube(new Vector3(-2.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(-0.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(1.5f, -2.5f, 0), cubeDimensions);
        Gizmos.DrawCube(new Vector3(3.5f, -2.5f, 0), cubeDimensions);

        //front row - white
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