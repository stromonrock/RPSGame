using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGame.Core
{
    /// <summary>
    /// Human Class
    /// </summary>
    public class Human :Player,IPlayer
    {
        /// <summary>
        /// Human Player
        /// </summary>
        public Human()
        {
            this.Name = Constants.human;
            this.PlayerType = Enums.PlayerType.Human;

        }
    }
}
