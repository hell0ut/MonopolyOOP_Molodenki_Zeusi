using System;
using System.Collections.Generic;
using System.Text;


class JailPayFine : IJailRequest
{
    public int PlayerId { get; set; }

    public JailPayFine(int playerId)
    {
        PlayerId = playerId;
    }
}

