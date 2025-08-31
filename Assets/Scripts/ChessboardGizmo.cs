using UnityEngine;

public class ChessboardGizmo : MonoBehaviour
{
    int x = 8;
    int y = 8;

    private void OnDrawGizmos()
    {
        int i = 0;
        int ii = 0;

        Gizmos.color = Color.yellow;
        while (i < y)
        {
            while (ii < x)
            {
                Gizmos.DrawWireCube(new Vector3(ii, i, 0), new Vector3(1, 1, 0));
                // Debug.Log("Gizmo drawn");

                ii++;
            }
            ii = 0;
            i++;
        }
    }
}