using System;
using System.Collections.Generic;
using System.Text;


interface IJailRequest : IEntityComponent
{
    public int PlayerId { get; set; }
}

