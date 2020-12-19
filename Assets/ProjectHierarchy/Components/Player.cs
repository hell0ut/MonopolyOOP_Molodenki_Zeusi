using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using UnityEngine;

class Player : MonoBehaviour,IEntityComponent
{

    public int Id;
    public string DisplayName;
    public int Cash;
    public int JailCards;
    public int? TurnsInJail;
    public int CurTileId;
    public bool CanMove;
    public bool IsBankrupt;
    public bool IsWinner;
    public bool RolledJailDiceThisTurn;
    public HashSet<int> Properties;

    public Player(int id, string displayName, int cash,
        HashSet<int> properties, int jailCards, int? turnsInPrison, int curTileId, bool rolledJailDiceThisTurn)
    {
        Id = id;
        DisplayName = displayName;
        Cash = cash;
        Properties = properties;
        JailCards = jailCards;
        TurnsInJail = turnsInPrison;
        CanMove = true;
        CurTileId = curTileId;
        RolledJailDiceThisTurn = rolledJailDiceThisTurn;
    }

    public Player(int id, string displayName, HashSet<int> props = null)
    {
        Id = id;
        DisplayName = displayName;
        Properties = props ?? new HashSet<int>();
    }
}
