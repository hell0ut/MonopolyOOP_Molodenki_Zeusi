using System;
using System.Collections.Generic;
using System.Text;


class PayOffDebtRequest : IRequest
{
    public int DebtAmount { get; set; }

    public PayOffDebtRequest(int debtAmount)
    {
        DebtAmount = debtAmount;
    }
}

