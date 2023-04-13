using System;
using System.Linq;

namespace LinqChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter a list of numbers (separated by commas): ");
      string input = Console.ReadLine()  ?? "";

      int[] numbers = input.Split(',')
                           .Select(x => int.Parse(x.Trim()))
                           .Where(x => x <= 1000)
                           .OrderByDescending(x => x)
                           .ToArray();
      Console.WriteLine($"Filtered list (in descending order): {string.Join(", ", numbers)}");
    }
  }
}
