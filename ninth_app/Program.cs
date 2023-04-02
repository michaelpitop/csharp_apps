using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!");
            Console.WriteLine("Enter your choice (Rock, Paper, or Scissors):");

            // Get the user's choice
            string userChoice = Console.ReadLine().ToLower();

            // Generate the computer's choice
            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            // Convert the computer's choice to a string
            string computerChoiceString;
            switch (computerChoice)
            {
                case 1:
                    computerChoiceString = "rock";
                    break;
                case 2:
                    computerChoiceString = "paper";
                    break;
                case 3:
                    computerChoiceString = "scissors";
                    break;
                default:
                    computerChoiceString = "";
                    break;
            }

            // Determine the winner
            if (userChoice == computerChoiceString)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoiceString == "scissors") ||
                     (userChoice == "paper" && computerChoiceString == "rock") ||
                     (userChoice == "scissors" && computerChoiceString == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("The computer wins!");
            }

            Console.WriteLine($"You chose {userChoice} and the computer chose {computerChoiceString}.");
            Console.ReadLine();
        }
    }
}

