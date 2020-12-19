using System;
using System.Collections.Generic;
using System.Text;


class TradeValidationRequest : IRequest
{
    public TradeOffer TradeOffer { get; set; }

    public TradeValidationRequest(TradeOffer tradeOffer)
    {
        TradeOffer = tradeOffer;
    }
}

