using System;

namespace RPSGame.Core
{
    /// <summary>
    /// Enumerator defined for the game
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// Type of moves 
        /// </summary>
        public enum Move
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        };
        /// <summary>
        /// Game Results
        /// </summary>
        public enum GameResult { HumanWin, ComputerWin, Draw };

        /// <summary>
        /// Player Type
        /// </summary>
        public enum PlayerType { Human, Computer };
    }
}
