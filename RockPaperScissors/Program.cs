using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            
            p1.GetPlayerName();
            p1.NeedRules();
        }
    }

    public class Player
    {
        string playerName;
        int playerWinCount = 0;
        int playerStreakCount = 0;

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

            string rules = Console.ReadLine();

            if (rules == "n")
            {
                Console.WriteLine("Great! Let's play! ");
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
            }

            else
            {
                Console.WriteLine("Please make a valid selection");
                NeedRules();
            }
        }

        public string PlayerSelection()
        {
            
            Console.WriteLine("'R' for Rock ");
            Console.WriteLine("'P' for Paper ");
            Console.WriteLine("'S' for Scissors ");
        }
    }
}
