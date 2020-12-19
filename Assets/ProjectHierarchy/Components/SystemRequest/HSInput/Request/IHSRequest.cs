using System;
using System.Collections.Generic;
using System.Text;


interface IHSRequest : IEntityComponent
{
    public int PlayerId { get; set; }
}
