using System;
using System.Collections.Generic;
using System.Text;


class PlayerLanded : IEntityComponent
{
    public int PlayerId { get; set; }

    public PlayerLanded(int playerId)
    {
        PlayerId = playerId;
    }
}

