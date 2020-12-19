using System;
using System.Collections.Generic;
using System.Text;


class SendToJail : IJailRequest
{
    public int PlayerId { get; set; }

    public SendToJail(int playerId)
    {
        PlayerId = playerId;
    }
}

