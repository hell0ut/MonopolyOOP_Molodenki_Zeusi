using System;
using System.Collections.Generic;
using System.Text;


class JailDiceRoll : IJailRequest
{
    public int PlayerId { get; set; }

    public JailDiceRoll(int playerId)
    {
        PlayerId = playerId;
    }
}

