using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTileContent : MonoBehaviour
{
    [SerializeField]
    GameTileContentType type = default;

    public GameTileContentType Type => type;

    GameTileContentFactory originFactory;

    public GameTileContentFactory OriginFactory
    {
        get => originFactory;
        set
        {
            Debug.Assert(originFactory == null, "Redefined origin factory!");
            originFactory = value;
        }
    }

    public void Recycle()
    {
        originFactory.Reclaim(this);
    }
}
