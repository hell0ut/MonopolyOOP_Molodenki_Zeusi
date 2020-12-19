using MonopolyPreUnity.Utitlity;
using System;
using System.Collections.Generic;
using System.Text;


class HSCommandChoiceRequest : IHSRequest
{
    public int PlayerId { get; set; }
    public List<MonopolyCommand> Commands { get; set; }

    public HSCommandChoiceRequest(List<MonopolyCommand> commands, int playerId)
    {
        PlayerId = playerId;
        Commands = commands;
    }
}

