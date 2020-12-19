
using System;


class GoToTileComponentAction : IMonopolyAction
{
    public Type ComponentType { get; set; }

    public GoToTileComponentAction(Type componentType)
    {
        ComponentType = componentType;
    }
}
