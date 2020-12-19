﻿using MonopolyPreUnity.Utitlity;
using System;
using System.Collections.Generic;
using System.Text;


class HSCommandChoice : IHSChoice
{
    public int PlayerId { get; set; }
    public MonopolyCommand Command { get; set; }

    public HSCommandChoice(MonopolyCommand command, int playerId)
    {
        PlayerId = playerId;
        Command = command;
    }
}

