// ~~user chooses their name~~
// ~~user gets to choose one of the selected races~~

// each race has different attributes
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
            playerInput.Name = Console.ReadLine();

            Console.WriteLine("Please choose a race:  \n1. Human \n2. Elf \n3. Dwarf \n4. Orc \n5. Goblin");


            int raceChoice = 0;
            string raceString = "";

            bool validInput = false;
            while (!validInput)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out raceChoice) && raceChoice >= 1 && raceChoice <= 5)
                {
                    validInput = true;
                    switch (raceChoice)
                    {
                        case 1:
                            raceString = "Human";
                            Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                            break;
                        case 2:
                            raceString = "Elf";
                            Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                            break;
                        case 3:
                            raceString = "Dwarf";
                            Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                            break;
                        case 4:
                            raceString = "Orc";
                            Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                            break;
                        case 5:
                            raceString = "Goblin";
                            Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                            break;
                        default:
                          raceString = "Invalid";
                          Console.WriteLine($"Your name is {playerInput.Name} and your chosen race is {raceString}");
                          break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                    break;
                }
                playerInput.Race = raceChoice;
            }

        }
    }

    public class PlayerInput
    {
        private string _name = "";
        private int _race;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Race
        {
          get { return _race; }
          set { _race = value; }
        }


    }
}
