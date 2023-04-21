﻿// ~~user chooses their name~~
// ~~user gets to choose one of the selected races~~

// ~~each race has different attributes~~
  // ~~1. we need to add all races in an array~~
  // ~~2. all objects in the array needs to have specific stats~~

// we add multiple enemies like last time (not public)


// add a multiplier with random effect and whenever its above *2 it gives a  message about critical hit

using System;
using System.Collections.Generic;

namespace RPGGame2
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayerInput playerInput = new PlayerInput();

            Console.WriteLine("Please enter your name: ");
            playerInput.Name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Please choose a race:  \n1. Human \n2. Elf \n3. Dwarf \n4. Orc \n5. Goblin");

            Race[] races = new Race[] {
              new Race("Human", 100, 10, 5),
              new Race("Elf", 90, 15, 5),
              new Race("Dwarf", 150, 5, 15),
              new Race("Orc", 150, 15, 5),
              new Race("Goblin", 50, 15, 0)
            };

            Enemy[] enemies = new Enemy[] {
              new Enemy("Zombie", 50, 5, 5),
              new Enemy("Troll", 200, 15, 5),
              new Enemy("Bandit", 100, 10, 10),
              new Enemy("Wolf", 50, 5, 5),
              new Enemy("Droid", 50, 10, 5)
            };


            int raceChoice = 0;

            bool validInput = false;
            while (!validInput)
            {
                if (int.TryParse(Console.ReadLine(), out raceChoice) && raceChoice >= 1 && raceChoice <= 5)
                {
                    validInput = true;
                    playerInput.Race = races[raceChoice - 1];
                    Console.WriteLine($"Your Characters Information: \nName: {playerInput.Name} \nRace: {playerInput.Race.RaceName} \nHealth: {playerInput.Race.Health} \nAttack: {playerInput.Race.Attack} \nDefense: {playerInput.Race.Defense}");
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }

          Random random = new Random();
          int index = random.Next(enemies.Length);
          Console.WriteLine("\nYou're being attacked by a " + enemies[index].RaceName + "!");
        }
    }

    public class PlayerInput
    {
        private string _name = "";
        private Race? _race;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Race Race
        {
          get { return _race!; }
          set { _race = value; }
        }
    }

    public class Race
    {
      private string _raceName = "";
      private int _health;
      private int _attack;
      private int _defense;

      public Race(string raceName, int health, int attack, int defense)
      {
        _raceName = raceName;
        _health = health;
        _attack = attack;
        _defense = defense;
      }

      public virtual string RaceName
      {
        get { return _raceName; }
      }

      public int Health
      {
        get { return _health; }
      }

      public int Attack
      {
        get { return _attack; }
      }

      public int Defense
      {
        get { return _defense; }
      }
    }

        public class Enemy : Race
    {
        private string _enemyName;

        public Enemy(string enemyName, int health, int attack, int defense) : base("", health, attack, defense)
        {
            _enemyName = enemyName;
        }

        public override string RaceName
        {
            get { return _enemyName; }
        }
    }
}
