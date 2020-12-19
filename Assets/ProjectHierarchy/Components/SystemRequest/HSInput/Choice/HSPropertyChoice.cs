using System;
using System.Collections.Generic;
using System.Text;


class HSPropertyChoice : IHSChoice
{
    public int PlayerId { get; set; }
    public int? PropId{ get; set; }

    public HSPropertyChoice(int playerId, int? propId)
    {
        PlayerId = playerId;
        PropId = propId;
    }
}

