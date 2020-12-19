using System;
using System.Collections.Generic;
using System.Text;


class CollectRent : IEntityComponent
{
    public int RenteeId { get; set; }

    public CollectRent(int renteeId)
    {
        RenteeId = renteeId;
    }
}

