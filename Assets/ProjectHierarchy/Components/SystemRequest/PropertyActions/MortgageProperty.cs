using System;
using System.Collections.Generic;
using System.Text;


class MortgageProperty : IPropertyAction
{
    public int PlayerId { get; set; }
    public int PropertyId { get; set; }

    public MortgageProperty(int playerId, int propertyId)
    {
        PlayerId = playerId;
        PropertyId = propertyId;
    }
}
