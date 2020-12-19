using System;
using System.Collections.Generic;
using System.Text;


class HSPlayerChoiceRequest : IHSRequest
{
    public int PlayerId { get; set; }
    public List<int> AvailablePlayers { get; set; }

    public HSPlayerChoiceRequest(int playerId, List<int> availablePlayers)
    {
        PlayerId = playerId;
        AvailablePlayers = availablePlayers;
    }
}

