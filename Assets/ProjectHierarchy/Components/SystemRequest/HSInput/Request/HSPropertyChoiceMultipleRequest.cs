using System;
using System.Collections.Generic;
using System.Text;


class HSPropertyChoiceMultipleRequest : IHSRequest
{
    public int PlayerId { get; set; }
    public List<int> AvailableProperties { get; set; }

    public HSPropertyChoiceMultipleRequest(int playerId, List<int> availableProperties)
    {
        PlayerId = playerId;
        AvailableProperties = availableProperties;
    }
}
