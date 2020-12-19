using System;
using System.Collections.Generic;
using System.Text;


class HSPlayerChoice : IHSChoice
{
    public int PlayerId { get; set; }
    public int? PlayerChoiceId { get; set; }

    public HSPlayerChoice(int playerId, int? playerChoiceId)
    {
        PlayerId = playerId;
        PlayerChoiceId = playerChoiceId;
    }
}

