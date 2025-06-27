using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public void Initialize(Vector2Int board)
    {
        float max = Mathf.Max(board.x, board.y);
        transform.position = new Vector3(0f, max+3, 0f);
        Debug.Log(new Vector3(0f, max, 0f));
    }
}
