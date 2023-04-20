// ~~user chooses their name~~
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
              new Race("Human", 10, 10, 5, 5),
              new Race("Elf", 5, 15, 15, 5),
              new Race("Dwarf", 15, 5, 10, 10),
              new Race("Orc", 15, 5, 5, 15),
              new Race("Goblin", 5, 15, 5, 15)
            };


            int raceChoice = 0;
            // string raceString = "";

            bool validInput = false;
            while (!validInput)
            {
                if (int.TryParse(Console.ReadLine(), out raceChoice) && raceChoice >= 1 && raceChoice <= 5)
                {
                    validInput = true;
                    playerInput.Race = races[raceChoice - 1];
                    Console.WriteLine($"Your name is {playerInput.Name}. Your chosen race is {playerInput.Race.Name}. Stats: Strength: {playerInput.Race.Strength}, Dexterity: {playerInput.Race.Dexterity}, Intelligence: {playerInput.Race.Intelligence}, Cunning: {playerInput.Race.Cunning}");
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }

                // string input = Console.ReadLine() ?? string.Empty;
                // if (int.TryParse(input, out raceChoice) && raceChoice >= 1 && raceChoice <= 5)
                // {
                //     validInput = true;
                //     switch (raceChoice)
                //     {
                //         case 1:
                //             raceString = "Human";
                //             Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                //             break;
                //         case 2:
                //             raceString = "Elf";
                //             Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                //             break;
                //         case 3:
                //             raceString = "Dwarf";
                //             Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                //             break;
                //         case 4:
                //             raceString = "Orc";
                //             Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                //             break;
                //         case 5:
                //             raceString = "Goblin";
                //             Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                //             break;
                //         default:
                //           raceString = "Invalid";
                //           Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                //           break;
                //     }
                // }
                // else
                // {
                //     Console.WriteLine("Invalid input, please try again.");
                //     break;
                // }
                // playerInput.Race = raceChoice;
            }

        }
    }

    public class PlayerInput
    {
        private string _name = "";
        private Race _race;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Race Race
        {
          get { return _race; }
          set { _race = value; }
        }
    }

    public class Race
    {
      private string _name = "";
      private int _strength;
      private int _dexterity;
      private int _intelligence;
      private int _cunning;

      public Race(string name, int strength, int dexterity, int intelligence, int cunning)
      {
        _name = name;
        _strength = strength;
        _dexterity = dexterity;
        _intelligence = intelligence;
        _cunning = cunning;
      }

      public string Name
      {
        get { return _name; }
      }

      public int Strength
      {
        get { return _strength; }
      }

      public int Dexterity
      {
        get { return _dexterity; }
      }

      public int Intelligence
      {
        get { return _intelligence; }
      }

      public int Cunning
      {
        get { return _cunning; }
      }

    }
}
