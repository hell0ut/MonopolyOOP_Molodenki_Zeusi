﻿
using System;
using System.Collections.Generic;
using System.Text;


class AssetTransferRequest : IEntityComponent
{
    public int? ReceiverId { get; set; }
    public PlayerAssets Assets { get; set; }

    public AssetTransferRequest(int? receiverId, PlayerAssets assets)
    {
        ReceiverId = receiverId;
        this.Assets = assets;
    }

    public AssetTransferRequest(int? receiverId, Player player) : this(receiverId, new PlayerAssets(player)) { }
}

