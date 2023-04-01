using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a series of positive numbers (enter a negative number to exit):");

        int sum = 0;
        int count = 0;

        while (true)

        {
          if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
          {
            sum += number;
            count++;
          }
          else
          {
            break;
          }
        }
        if (count > 0)
        {
          double average = (double) sum / count;
          Console.WriteLine($"The sum is {sum} and the average is {average:N2}");
        }
        else
        {
          Console.WriteLine("No positive numbers were entered.");
        }
          Console.ReadLine();
    }
}
