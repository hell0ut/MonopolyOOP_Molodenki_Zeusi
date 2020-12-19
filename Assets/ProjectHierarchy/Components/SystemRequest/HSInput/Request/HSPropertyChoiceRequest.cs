using System;
using System.Collections.Generic;
using System.Text;


class HSPropertyChoiceRequest : IHSRequest
{
    public int PlayerId { get; set; }
    public List<int> Properties { get; set; }

    public HSPropertyChoiceRequest(int playerId, List<int> properties)
    {
        PlayerId = playerId;
        Properties = properties;
    }
}

