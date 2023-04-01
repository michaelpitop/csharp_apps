using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guessing Game!");

        Random random = new Random();
        int numberToGuess = random.Next(1, 11);
        int numberOfGuesses = 0;

        while (true)
        {
            Console.Write("Enter your guess (1-10): ");

            if (!int.TryParse(Console.ReadLine(), out int guess))
            {
                Console.WriteLine("Invalid input, please enter a number.");
                continue;
            }

            numberOfGuesses++;

            if (guess == numberToGuess)
            {
                Console.WriteLine($"Congratulations, you guessed the number in {numberOfGuesses} guesses!");
                break;
            }
            else if (guess < numberToGuess)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else
            {
                Console.WriteLine("Your guess is too high.");
            }
        }

        Console.ReadLine();
    }
}
