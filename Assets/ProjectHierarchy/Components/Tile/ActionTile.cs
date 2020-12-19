using UnityEngine;

class ActionTile :MonoBehaviour, IEntityComponent
{
    public IMonopolyAction Action;

    public ActionTile(IMonopolyAction action) =>
        Action = action;
}

