using System;
using System.Collections.Generic;
using System.Text;


class PlayerBankrupt : IEntityComponent
{
    public int PlayerId { get; set; }

    public PlayerBankrupt(int playerId)
    {
        PlayerId = playerId;
    }
}

