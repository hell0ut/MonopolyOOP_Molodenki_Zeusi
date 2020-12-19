



class TaxPerHouseAction : IMonopolyAction
{
    public int Amount { get; set; }

    public TaxPerHouseAction(int amount)
    {
        Amount = amount;
    }
}
