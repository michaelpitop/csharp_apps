using System;

namespace WordCountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence or a paragraph:");
            string userInput = Console.ReadLine();

            // Split the input string into an array of words
            string[] words = userInput.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Count the number of words
            int wordCount = words.Length;

            // Display the word count
            Console.WriteLine("The number of words in the input is: " + wordCount);

            Console.ReadLine();
        }
    }
}
