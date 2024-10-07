using PigDiceGame.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame.Presentation
{
    internal class PigDiceMenu
    {
        static PigDiceManager manager = new PigDiceManager();
        static int totalScore = 0; 
        const int maxScore = 20;
        static bool turnActive = true;
        static int turnScore = 0;
        static int currentTurn = 1;

        public static void MainInterface()
        {
            Console.WriteLine("----------- Welcome to Pig Dice Game -----------");
            while (true)
            {
                CheckMaxScore();

                Console.WriteLine("Want to play again\n" +
                    "1. Yes\n" +
                    "2. No\n");

                int choice = int.Parse(Console.ReadLine());

                PlayAgain(choice);
            }
           
        }
        public static void CheckMaxScore()
        {
            while (totalScore < maxScore)
            {
                ActiveTurn();
            }
        }
        public static void ActiveTurn()
        {
            turnActive = true;
            while (turnActive)
            {
                Console.WriteLine($"---- Current Turn: {currentTurn} ----");
                Console.WriteLine("Choose the step\n" +
                        "1. Roll up - r\n" +
                        "2. Hold - h\n");

                string choice = Console.ReadLine();
                Console.WriteLine();
                SwitchMenu(choice);
            }
        }

        public static void SwitchMenu(string choice)
        {
            switch (choice)
            {
                case "r":
                    RollUp();
                    break;
                case "h":
                    Hold();
                    break;
                default:
                    Console.WriteLine("Choose the correct choice\n");
                    break;
            }
        }

        public static void RollUp()
        {
            int currentScore = manager.DiceRoll();
            Console.WriteLine($"You rolled {currentScore}");

            //Use the condition if the number get from dice is 1
            //If the number is 1 then turn will end and new turn start
            if (currentScore == 1)
            {
                Console.WriteLine("Oops! You rolled a 1. Turn ends, and you lose your turn score.\n");
                turnActive = false;
                turnScore = 0;
                currentTurn++;
            }
            //If the number is other than 1 i.e. (between 2 to 6) then current score is added to turnscore
            //Checks if the turnscore is greater than maxscore i.e. (20)
            else
            {
                turnScore += currentScore;
                Console.WriteLine($"Your Total Score is {turnScore}\n");
                IsMaxScore(turnScore);
            }
        }

        static void IsMaxScore(int turnScore)
        {
            //If turn score is greater than 20 then it store in totalscore and turn will end
            if (turnScore >= 20)
            {
                totalScore = turnScore;
                turnActive = false;
                Console.WriteLine("Congratulation!!!! You Win the Game.\n");
            }
        }
        public static void Hold()
        {
            //when you choose hold the turn will ends and totalscore and turnscore is reset 
            Console.WriteLine("You Hold the Score");
            totalScore += turnScore;
            Console.WriteLine($"Your Total Score is {totalScore}\n");
            turnActive = false;
            turnScore = 0;
            totalScore = 0;
            currentTurn++;
        }

        public static void PlayAgain(int choice)
        {
            switch (choice)
            {
                case 1:
                    totalScore = 0;
                    turnScore = 0;
                    currentTurn = 1;
                    CheckMaxScore();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter a valid choice.");
                    break;
            }
        }
    }
}
