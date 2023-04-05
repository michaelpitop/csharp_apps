using System;
using System.Text;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Generated password: " + GeneratePassword());
    }

    static string GeneratePassword() {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{};:,.<>?";
        StringBuilder password = new StringBuilder();
        Random rnd = new Random();
        for (int i = 0; i < 20; i++) {
            password.Append(validChars[rnd.Next(validChars.Length)]);
        }
        return password.ToString();
    }
}
