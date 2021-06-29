using System;
using System.Collections.Generic;
using System.Text;
using static RPSGame.Core.Enums;

namespace RPSGame.Core
{
    /// <summary>
    /// Computer Player
    /// </summary>
    public class Computer : Player, IPlayer
    {

        static Array values = Enum.GetValues(typeof(Move));

        /// <summary>
        /// Initialize the default values
        /// </summary>
        public Computer()
        {
            this.Name = Constants.computer;
            this.PlayerType = Enums.PlayerType.Computer;
            this.Move = GetMove();
        }
        /// <summary>
        ///  Get Computer Move
        /// </summary>
        /// <returns></returns>
        public Move GetMove()
        {
            Random random = new Random();

            this.Move = (Move)values.GetValue(random.Next(values.Length));

            return this.Move;
        }
    }
}
