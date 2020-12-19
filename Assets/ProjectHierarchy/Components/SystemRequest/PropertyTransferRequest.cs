using System;
using System.Collections.Generic;
using System.Text;


class PropertyTransferRequest : IEntityComponent
{
    public int PropertyId { get; set; }
    public int NewOwnerId { get; set; }

    public PropertyTransferRequest(int propertyId, int newOwnerId)
    {
        PropertyId = propertyId;
        NewOwnerId = newOwnerId;
    }
}

