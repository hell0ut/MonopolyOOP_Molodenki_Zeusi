using System;
using System.Collections.Generic;
using System.Text;


class BuildHouse : IPropertyAction
{
    public int PlayerId { get; set; }
    public int PropertyId { get; set; }

    public BuildHouse(int playerId, int propertyId)
    {
        PlayerId = playerId;
        PropertyId = propertyId;
    }
}

