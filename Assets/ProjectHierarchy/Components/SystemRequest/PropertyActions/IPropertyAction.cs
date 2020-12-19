using System;
using System.Collections.Generic;
using System.Text;

interface IPropertyAction : IEntityComponent
{
    public int PropertyId { get; set; }
    public int PlayerId { get; set; }
}

