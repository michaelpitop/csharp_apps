using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your email address: ");
        string email = Console.ReadLine() ?? string.Empty;

        // Define a regular expression pattern for validating email addresses
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Create a regular expression object with the pattern
        Regex regex = new Regex(pattern);

        // Use the regular expression object to validate the input
        if (regex.IsMatch(email))
        {
            Console.WriteLine("Valid email address.");
        }
        else
        {
            Console.WriteLine("Invalid email address.");
        }

        Console.ReadKey();
    }
}
