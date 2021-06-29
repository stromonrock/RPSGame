using System;
using System.Collections.Generic;
using System.Text;
using static RPSGame.Core.Enums;

namespace RPSGame.Core
{
    /// <summary>
    /// Play Game 
    /// </summary>
    public class GamePlay : IGamePlay
    {
        public IPlayer Player1 { get; }
        public IPlayer Player2 { get; }

        /// <summary>
        /// Game play Constructor
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public GamePlay(IPlayer player1, IPlayer player2)
        {
            if ((player1 == null) || (player2 == null))
            {
                throw new Exception("player is not define");
            }

            if ((player1 is Human) && (player2 is Human))
            {
                throw new Exception("Both are human");
            }

            Player1 = player1;
            Player2 = player2;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public GameResult GetWinner()
        {
            return GetWinner(Player1, Player2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <returns></returns>
        public GameResult GetWinner(IPlayer player1, IPlayer player2)
        {
            GameResult result = GameResult.Draw;

            if ((player1.Move == Move.Paper && player2.Move == Move.Rock) ||
                (player1.Move == Move.Rock && player2.Move == Move.Scissors) ||
                (player1.Move == Move.Scissors && player2.Move == Move.Paper))
            {
                result = player1.PlayerType == PlayerType.Computer ? GameResult.ComputerWin : GameResult.HumanWin;
            }
            if ((player1.Move == Move.Rock && player2.Move == Move.Paper) ||
               (player1.Move == Move.Scissors && player2.Move == Move.Rock) ||
               (player1.Move == Move.Paper && player2.Move == Move.Scissors))
            {
                result = player2.PlayerType == PlayerType.Computer ? GameResult.ComputerWin : GameResult.HumanWin;
            }

            return result;
        }


    }
}
