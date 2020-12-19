using System;
using System.Collections.Generic;
using System.Text;


class PaidOffDebt : IEntityComponent
{
    public int PlayerId { get; set; }

    public PaidOffDebt(int playerId) =>
        PlayerId = playerId;
}

