using System;
using System.Collections.Generic;
using System.Text;


class JailUseCard : IJailRequest
{
    public int PlayerId { get; set; }

    public JailUseCard(int playerId)
    {
        PlayerId = playerId;
    }
}

