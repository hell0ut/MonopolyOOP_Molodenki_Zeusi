using UnityEngine;


    interface IIdentifiable : IEntityComponent
    {
        public int Id { get; }
    }
