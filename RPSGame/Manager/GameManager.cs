using RPSGame.Core;
using System;
using System.Collections.Generic;
using System.Text;
using static RPSGame.Core.Enums;

namespace RPSGame
{
    /// <summary>
    /// Game Manager 
    /// </summary>
    public class GameManager
    {
        /// <summary>
        /// Here Acctual Game Initialize 
        /// </summary>
        public static void Initialization()
        {

            bool loop = true;
            int humanPoints = 0;
            int computerPoints = 0;

            Console.WriteLine("Play Rock, Paper, Scissors game best of 3 wins. ");
            // Loop will work till human or computer either of them wins
            while (loop)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine("Please enter your choice :");
                Console.WriteLine("==============================================================================");

                Console.WriteLine("1.Rock");
                Console.WriteLine("2.Paper");
                Console.WriteLine("3.Scissors");


                string humanChoice = Console.ReadLine();

                IPlayer humanPlayer = new Human
                {
                    Move = (Enums.Move)Convert.ToInt32(humanChoice)
                };

                IPlayer computerPlayer = new Computer();

                IGamePlay gamePlay = new GamePlay(humanPlayer, computerPlayer);
                GameResult gameResult = gamePlay.GetWinner();

                Console.WriteLine($"Human Played : { humanPlayer.Move } ");
                Console.WriteLine($"Computer Played : { computerPlayer.Move } ");

               

                if (gameResult == GameResult.ComputerWin)
                {
                    computerPoints++;
                }
                else if (gameResult == GameResult.HumanWin)
                {
                    humanPoints++;
                }
                else
                {
                    Console.WriteLine($"Draw between Human and Computer");
                }

                Console.WriteLine($"Human has {humanPoints} points - Computer has {computerPoints} points");

                if (humanPoints > 1 || computerPoints > 1)
                {
                    if (humanPoints > 1 && computerPoints <= 1)
                        Console.WriteLine("Human Wins");

                    if (computerPoints > 1 && humanPoints <= 1)
                        Console.WriteLine("Computer Wins");

                    // Play again 
                    Console.WriteLine("Do you wish to play again?");
                    Console.WriteLine("Enter Y or N");
                    string playAgain = Console.ReadLine();

                    if (playAgain == "N" || playAgain == "n" || playAgain == "no")
                    {
                        loop = false;
                    }
                    else
                    {
                        humanPoints = 0;
                        computerPoints = 0;
                    }
                }
            }

        }

    }
}
