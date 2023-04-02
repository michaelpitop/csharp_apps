using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Select an operation (+ - * /): ");
        char op = char.Parse(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator selected.");
                break;
        }

        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        Console.ReadLine();
    }
}
