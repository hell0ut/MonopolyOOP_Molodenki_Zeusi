class ChangeBalanceAction : IMonopolyAction
{
    public int Amount;

    public ChangeBalanceAction(int amount)
    {
        Amount = amount;
    }
}
