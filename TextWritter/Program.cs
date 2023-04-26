using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        // Ask user for filename and text to write
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter text: ");
        string text = Console.ReadLine() ?? string.Empty;

        // Create new file and write text to it
        using (StreamWriter sw = File.CreateText(filename)) {
            sw.Write(text);
        }

        Console.WriteLine($"Text written to file '{filename}'");
    }
}
