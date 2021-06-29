using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RPSGame.Core;
using static RPSGame.Core.Enums;

namespace RPSGame.CoreTest
{
    [TestClass]
    public class CoreTest
    {
        [TestMethod]
        public void PaperBeatsRock()
        {

            IPlayer computer = new Computer
            {
                Move = Move.Paper
            };

            IPlayer human = new Human
            {
                Move = Move.Rock
            };

            IGamePlay GamePlay = new GamePlay(human, computer);

            GameResult gameResult = GamePlay.GetWinner();

            Assert.IsTrue(gameResult == GameResult.ComputerWin, "Paper should beat rock");
        }
    }
}
