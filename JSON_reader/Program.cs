using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Read the JSON file
        string json = File.ReadAllText("books.json");

        // Deserialize the JSON into a dynamic object
        dynamic data = JsonConvert.DeserializeObject(json);

        // Display the books in the console
        foreach (var book in data.books)
        {
            Console.WriteLine("Title: " + book.title);
            Console.WriteLine("Author: " + book.author);
            Console.WriteLine("Year: " + book.year);
            Console.WriteLine();
        }

        // Wait for the user to press a key before closing the console
        Console.ReadKey();
    }
}
