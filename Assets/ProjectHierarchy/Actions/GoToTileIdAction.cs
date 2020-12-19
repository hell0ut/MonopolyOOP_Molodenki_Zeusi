

namespace MonopolyPreUnity.Actions
{
    class GoToTileIdAction : IMonopolyAction
    {
        public int TileId { get; set; }

        public GoToTileIdAction(int tileId)
        {
            TileId = tileId;
        }
    }
}
