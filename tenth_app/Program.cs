using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a task to add to your to-do list, or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    toDoList.Add(input);
                    Console.WriteLine("Task added to to-do list.");
                }
            }

            Console.WriteLine("\nYour to-do list:");
            foreach (string task in toDoList)
            {
                Console.WriteLine(task);
            }

            Console.ReadLine();
        }
    }
}
