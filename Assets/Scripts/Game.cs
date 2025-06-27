using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    [SerializeField]
    Vector2Int boardSize = new Vector2Int(11, 11);

    [SerializeField]
    GameBoard board = default;

    [SerializeField]
    CameraController cam = default;

    [SerializeField]
    private GameTileContentFactory tileContentFactory;

    Ray TouchRay => Camera.main.ScreenPointToRay(Input.mousePosition);

    void Start()
    {
        cam.Initialize(boardSize);
        board.Initialize(boardSize, tileContentFactory);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Handle");
            HandleTouch();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log("HandleAlter");
            HandleAlternativeTouch();
        }
    }

    void HandleAlternativeTouch()
    {
        GameTile tile = board.GetTile(TouchRay);
        if (tile != null)
        {
            board.ToggleDestination(tile);
        }
    }

    void HandleTouch()
    {
        GameTile tile = board.GetTile(TouchRay);
        if (tile != null)
        {
            //tile.Content = tileContentFactory.Get(GameTileContentType.Destination);
            board.ToggleWall(tile);
        }
    }

}
