using System;
using System.Collections.Generic;
using System.Text;
using static RPSGame.Core.Enums;

namespace RPSGame.Core
{
    /// <summary>
    /// player interface 
    /// </summary>
    public interface IPlayer
    {
        string Name { get; set; }
        PlayerType PlayerType { get; set; }
        Move Move { get; set; }
    }
}
