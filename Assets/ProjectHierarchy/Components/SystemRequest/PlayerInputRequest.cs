
using System;
using System.Collections.Generic;
using System.Text;


class PlayerInputRequest : IEntityComponent
{
    public int PlayerId { get; set; }
    public IRequest Request { get; set; }

    public PlayerInputRequest(int playerId, IRequest request)
    {
        PlayerId = playerId;
        Request = request;
    }
}

