using System;
using System.Collections.Generic;
using System.Text;
using static RPSGame.Core.Enums;

namespace RPSGame.Core
{
    /// <summary>
    /// Player class used to create a human or computer player type
    /// </summary>
    public abstract class Player
    {
        public string Name { get; set; }
        public PlayerType PlayerType { get; set; }
        public Move Move { get; set; }
    }
}
