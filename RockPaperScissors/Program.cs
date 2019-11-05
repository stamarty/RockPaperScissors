using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the player object
            Player p1 = new Player();

            p1.GetPlayerName();
            p1.NeedRules();

            //Create the Opponent object
            Opponent o1 = new Opponent();

            //start the game
            Game game = new Game();
            
            do
            {
                string playerDecision = p1.PlayerSelection();
                string opponentDecision = o1.OpponentSelection();

                Console.WriteLine("You chose {0}", playerDecision);
                Console.WriteLine("The Horde of Hamsters chose {0}", opponentDecision);
                game.WhoWins(playerDecision, opponentDecision);
                
            } while (game.PlayAgain());
        }
    }

    public class Player
    {
        string playerName;

        public void GetPlayerName()
        {
            Console.Write("Please enter your name! ");
            playerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to Rock, Paper, Scissors, {0}!", playerName);
        }

        public void NeedRules()
        {
            Console.WriteLine();
            Console.WriteLine(playerName + ", do you need a refresher on the rules?");
            Console.WriteLine("Press 'y' for yes or 'n' for no");
            Console.WriteLine();

            string rules = Console.ReadLine();

            if (rules == "n")
            {
                Console.WriteLine("Great! Let's play! ");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }

            else if (rules == "y")
            {
                Console.WriteLine(playerName + ", when prompted, you will type: ");
                Console.WriteLine();
                Console.WriteLine("'R' for Rock ");
                Console.WriteLine("'P' for Paper ");
                Console.WriteLine("'S' for Scissors ");
                Console.WriteLine();
                Console.WriteLine("Once you've made your selection, our horde of hamsters will make their own decision. ");
                Console.WriteLine();
                Console.WriteLine("Rock beats Scissors ");
                Console.WriteLine("Scissors beat Paper ");
                Console.WriteLine("Paper beats Rock ");
                Console.WriteLine();
                Console.WriteLine("It's just like the circle of life.");
                Console.WriteLine();
                Console.WriteLine("Press any key when ready to continue");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please make a valid selection");
                NeedRules();
            }
        }

        public string PlayerSelection()
        {
            Console.WriteLine("Do you choose: ");
            Console.WriteLine();
            Console.WriteLine("The strength of Rock? Press 'r'. ");
            Console.WriteLine("The finesse of Paper? Press 'p'. ");
            Console.WriteLine("The sharpness of Scissors? Press 's'. ");
            Console.WriteLine();

            string playerChose = Console.ReadLine();
            string playerChoice;

            if (playerChose == "r")
            {
                playerChoice = "Rock";
                return playerChoice;
            }

            else if (playerChose == "p")
            {
                playerChoice = "Paper";
                return playerChoice;
            }

            else if (playerChose == "s")
            {
                playerChoice = "Scissors";
                return playerChoice;
            }

            else
            {
                Console.WriteLine("Please make a valid selection");
                PlayerSelection();
                return null;
            }
        }
    }

    public class Opponent
    {
        public string OpponentSelection()
        {
            //use random to pull from Rock, Paper, Scissors.
            string[] rps = new string[] { "Rock", "Paper", "Scissors" };
            Random random = new Random();

            int index = random.Next(0, rps.Length);

            return rps[index];
        }
    }

    public class Game
    {
        int playerScore = 0;
        int opponentScore = 0;
        int tieScore = 0;

        public void WhoWins(string playerSelect, string opponentSelect)
        {
            //tie
            if (playerSelect == opponentSelect)
            {
                Console.WriteLine("Game is a tie! ");
                tieScore++;
            }
            //hamsters win
            else if (playerSelect == "Rock" && opponentSelect == "Paper")
            {
                Console.WriteLine("The Horde of Hamsters Wins! ");
                opponentScore++;
            }

            else if (playerSelect == "Paper" && opponentSelect == "Scissors")
            {
                Console.WriteLine("The Horde of Hamsters Wins! ");
                opponentScore++;
            }

            else if (playerSelect == "Scissors" && opponentSelect == "Rock")
            {
                Console.WriteLine("The Horde of Hamsters Wins! ");
                opponentScore++;
            }

            //player win
            else if (playerSelect == "Rock" && opponentSelect == "Scissors")
            {
                Console.WriteLine("You Win! ");
                playerScore++;
            }

            else if (playerSelect == "Paper" && opponentSelect == "Rock")
            {
                Console.WriteLine("You Win! ");
                playerScore++;
            }

            else if (playerSelect == "Scissors" && opponentSelect == "Paper")
            {
                Console.WriteLine("You Win! ");
                playerScore++;
            }

            Console.WriteLine("Player Score = {0} ", playerScore);
            Console.WriteLine("Hamster Score = {0} ", opponentScore);
            Console.WriteLine("Tie Score = {0} ", tieScore);
        }
    
        public bool PlayAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to play again? ");
            Console.WriteLine("Type 'y' for yes or 'n' for no. ");

            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                return true;
            }

            else if (playAgain == "n")
            {
                return false;
            }

            else
            {
                Console.WriteLine("Please make a valid selection. ");
                PlayAgain();
                return true;
            }
        }
    }
}
