using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int Id;
    public int MapPosition;
    public string Name;

    public Tile(int id, int mapPosition, string name)
    {
        Id = id;
        MapPosition = mapPosition;
        Name = name;
    }
}
