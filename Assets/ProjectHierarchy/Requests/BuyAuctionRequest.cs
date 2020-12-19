using System;
using System.Collections.Generic;
using System.Text;


class BuyAuctionRequest : IRequest
{
    public int PropertyId { get; set; }

    public BuyAuctionRequest(int propertyId)
    {
        PropertyId = propertyId;
    }
}

