using PigDiceGame.Presentation;

namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PigDiceMenu.MainInterface();

            //Random random = new Random();

            //Console.WriteLine("Welcome to pig dice game");

            //int totalScore = 0;

            //while (totalScore < 20)
            //{
            //    bool turnActive = true;
            //    int turnScore = 0;

            //    Console.WriteLine($"Current total Score is {turnScore}");

            //    while (turnActive)
            //    {
            //        Console.WriteLine("Choose the option\n" +
            //            "1. Roll up - r\n" +
            //            "2. Hold - h\n");

            //        string choice = Console.ReadLine();
            //        switch (choice)
            //        {
            //            case "r":
            //                int currentScore = random.Next(1, 7);
            //                Console.WriteLine($"You rolled {currentScore}");

            //                if (currentScore == 1)
            //                {
            //                    Console.WriteLine("Oops! You rolled a 1. Turn ends, and you lose your turn score.\n");
            //                    turnActive = false;
            //                    turnScore = 0;
            //                }
            //                else
            //                {
            //                    turnScore += currentScore;
            //                    Console.WriteLine($"Your Total Score is {turnScore}\n");
            //                    if (turnScore >= 20)
            //                    {
            //                        totalScore = turnScore;
            //                        turnActive = false;
            //                    }

            //                }
            //                break;
            //            case "h":
            //                Console.WriteLine("You Hold the Score");
            //                totalScore += turnScore;
            //                Console.WriteLine($"Your Total Score is {totalScore}\n");
            //                turnActive = false;
            //                break;
            //        }
            //    }
            //}

            //Console.WriteLine("Congratulation You reached the 20 points");
        }
    }
}
