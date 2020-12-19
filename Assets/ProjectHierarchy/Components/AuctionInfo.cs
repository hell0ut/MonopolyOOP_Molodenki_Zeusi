using System.Collections.Generic;

class AuctionInfo : IEntityComponent
{
    public int PropertyOnAuctionId { get; set; }
    public int AmountBid { get; set; }
    public List<int> BidOrder { get; set; }
    public int CurBidder { get; set; }
    public int CurBidderId => BidOrder[CurBidder];
    public int BiddersLeft => BidOrder.Count;

    public AuctionInfo(int propertyOnAuctionId, int amountBid, List<int> bidOrder, int curBidder)
    {
        PropertyOnAuctionId = propertyOnAuctionId;
        AmountBid = amountBid;
        BidOrder = bidOrder;
        CurBidder = curBidder;
    }

    public AuctionInfo()
    {
        BidOrder = new List<int>();
    }
}
