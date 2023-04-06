
// user chooses their name
// user gets to choose one of the selected races
// each race has different attributes

// we add multiple enemies like last time (not public)
// add a multiplier with random effect and whenever its above *2 it gives a  message about critical hit

using System;

namespace RPGGame2
{
  public class Programm
  {
    static void Main(string[] args)
    {
    PlayerInput playerInput = new PlayerInput();

    Console.WriteLine("Please enter your name: ");

    playerInput.Name = Console.ReadLine();

    Console.WriteLine("Please choose a race: ");

    playerInput.Race = int.Parse(Console.ReadLine());

    int _race;

    string _name;

    Console.WriteLine("Your name is " + $"{playerInput.Name}");
    Console.WriteLine($"{playerInput.Race}");

  }

  public class PlayerInput {
    private string _name;
    private int _race;

    public string Name  {
      get { return _name;}
      set { _name = value; }
      }

    public int Race {
      get { return _race; }
      set { _race = value; }
      }
    }

    }

}
