using System;
using System.Collections.Generic;
using System.Text;
using static RPSGame.Core.Enums;

namespace RPSGame.Core
{
    /// <summary>
    /// Game play interface 
    /// </summary>
    public interface IGamePlay
    {
        IPlayer Player1 { get; }
        IPlayer Player2 { get; }

        /// <summary>
        /// Get winner 
        /// </summary>
        /// <returns></returns>
        GameResult GetWinner();
        /// <summary>
        /// Get Winner by passing the players
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <returns></returns>
        GameResult GetWinner(IPlayer player1, IPlayer player2);
    }
}
