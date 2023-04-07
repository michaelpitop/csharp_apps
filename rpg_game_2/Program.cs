// user chooses their name
// user gets to choose one of the selected races
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

            List<string> raceOptions = new List<string>() { "Human", "Elf", "Dwarf", "Orc", "Goblin" };

            Console.WriteLine("Please choose a race: ");
            for (int i = 0; i < raceOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {raceOptions[i]}");
            }

            int raceChoice;
            while (!int.TryParse(Console.ReadLine(), out raceChoice) || raceChoice < 1 || raceChoice > raceOptions.Count)
            {
                Console.WriteLine($"Invalid input. Please choose a number between 1 and {raceOptions.Count}");
            }

            Console.WriteLine($"Your name is {playerInput.Name}");
            Console.WriteLine($"Your race is {playerInput.Race}");
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

            public List<string> RaceOptions
            {
                get
                {
                    return new List<string> {
                    "Human",
                    "Elf",
                    "Dwarf",
                    "Orc",
                    "Goblin"
                };
                }
            }

    }
}
