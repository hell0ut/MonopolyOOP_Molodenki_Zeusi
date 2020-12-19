using System;
using System.Collections.Generic;
using System.Text;


class UnmortgageProperty : IPropertyAction
{
    public int PlayerId { get; set; }
    public int PropertyId { get; set; }

    public UnmortgageProperty(int playerId, int propertyId)
    {
        PlayerId = playerId;
        PropertyId = propertyId;
    }
}

