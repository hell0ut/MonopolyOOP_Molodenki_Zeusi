using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{
    public int diceResult;
    public Text text;
    public void RollDice()
    {
        diceResult = Random.Range(1, 12);
        text.text = "Dice Result: "+ diceResult.ToString();
    }

}
