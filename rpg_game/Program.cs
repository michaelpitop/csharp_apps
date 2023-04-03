using System;

namespace RPGGame
{
  class Program
  {
    static void Main(string[] args)
    {
      // Player character
      string playerName;
      int playerHealth = 100;
      int playerAttack = 10;
      int playerDefense = 5;

      Console.WriteLine("Welcome to the RPG Game");
      Console.Write("Enter your name: ");
      playerName = Console.ReadLine();
      Console.WriteLine($"Welcome {playerName}");

      Console.WriteLine("\nHere are your stats:");
      Console.WriteLine($"Name: {playerName}");
      Console.WriteLine($"Health: {playerHealth}");
      Console.WriteLine($"Attack: {playerAttack}");
      Console.WriteLine($"Defense: {playerDefense}");

      // Enemy Character
      string enemyName = "Zombie";
      int enemyHealth = 50;
      int enemyAttack = 5;
      int enemyDefense = 2;

      Console.WriteLine($"\nYou encounter a {enemyName} with {enemyHealth} health.");

      // Battle loop

      while (playerHealth > 0 && enemyHealth > 0)
      {
        Console.WriteLine("\nWhat do you want to do?");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Defend");

        int choice = int.Parse(Console.ReadLine());

        // if player attacks
        if (choice == 1)
        {
          Console.WriteLine($"\nYou attack the {enemyName} for {playerAttack} damage.");
          enemyHealth -= playerAttack;
        }
        else if (choice == 2)
        {
          Console.WriteLine($"You brace for the enemy's attack.");
          playerHealth -= enemyAttack;
        }
        else
        {
          Console.WriteLine("Invalid choice, please try again!");
          continue;
        }

        // enemy attacks
        Console.WriteLine($"The {enemyName} attacks you for {enemyAttack} damage!");
        playerHealth -= enemyAttack - playerDefense;
        playerDefense = 5;

        // display Health
        Console.WriteLine($"\nYour health: {playerHealth}");
        Console.WriteLine($"\nEnemys health: {enemyHealth}");

      }

        // who wins
        if (playerHealth <= 0)
        {
          Console.WriteLine("\nYou Lost! :c");
        }
        else
        {
          Console.WriteLine($"You defeated the {enemyName}!");
        }

        Console.ReadLine();
    }
  }
}
