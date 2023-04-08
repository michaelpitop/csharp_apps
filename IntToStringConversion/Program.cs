Console.WriteLine("Please choose a race:  \n1. Human \n2. Elf \n3. Dwarf \n4. Orc \n5. Goblin");

string raceString = "";
int raceChoice = 0;

bool validInput = false;
while (!validInput)
{
    if (int.TryParse(Console.ReadLine(), out raceChoice) && raceChoice >= 1 && raceChoice <= 5)
    {
        validInput = true;
        switch (raceChoice)
        {
            case 1:
                raceString = "Human";
                Console.WriteLine($"Your chosen race is {raceString}");
                break;
            case 2:
                raceString = "Elf";
                Console.WriteLine($"Your chosen race is {raceString}");
                break;
            case 3:
                raceString = "Dwarf";
                Console.WriteLine($"Your chosen race is {raceString}");
                break;
            case 4:
                raceString = "Orc";
                Console.WriteLine($"Your chosen race is {raceString}");
                break;
            case 5:
                raceString = "Goblin";
                Console.WriteLine($"Your chosen race is {raceString}");
                break;
            default:
              raceString = "Invalid";
              Console.WriteLine($"Your chosen race is {raceString}");
              break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input, please try again.");
        break;
    }
}


// Console.WriteLine($"Your chosen race is {raceString}");
