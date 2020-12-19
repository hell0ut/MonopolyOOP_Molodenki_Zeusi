using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Player> playerList;
    private int turnCounter;
    public int turn;
    public DiceScript diceScript;
    public TileManager tileManager;


    public void MakeTurn()
    {
        var curPlayer = playerList[turnCounter % 3];
        curPlayer.CurTileId +=  (diceScript.RollDice())%40;
        var navAgent = curPlayer.GetComponent<NavMeshAgent>();
        navAgent.destination = (tileManager.tileDictionary[curPlayer.CurTileId]).GetComponent<Transform>().position;
        turnCounter++;

    }


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
