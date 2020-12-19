using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


class TrainStation :MonoBehaviour, IEntityComponent
{
    public int BaseRent;

    public TrainStation(int baseRent)
    {
        BaseRent = baseRent;
    }
}

