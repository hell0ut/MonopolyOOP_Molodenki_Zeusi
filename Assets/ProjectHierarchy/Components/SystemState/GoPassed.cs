using System;
using System.Collections.Generic;
using System.Text;


class GoPassed : IEntityComponent
{
    public int PlayerId { get; set; }

    public GoPassed(int playerId)
    {
        PlayerId = playerId;
    }
}

