using System;
using System.Collections.Generic;
using System.Text;


interface IAuctionAction : IEntityComponent
{
    public int PlayerId { get; set; }
}

