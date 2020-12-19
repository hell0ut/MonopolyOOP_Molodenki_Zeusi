using System;
using System.Collections.Generic;
using System.Text;


class SellHouse : IPropertyAction
{
    public int PlayerId { get; set; }
    public int PropertyId { get; set; }

    public SellHouse(int playerId, int propertyId)
    {
        PlayerId = playerId;
        PropertyId = propertyId;
    }
}

