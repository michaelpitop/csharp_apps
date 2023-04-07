Console.WriteLine("Please choose a race:  \n1. Human \n2. Elf \n3. Dwarf \n4. Orc \n5. Goblin");

string raceString = "";
int raceChoice = int.Parse(Console.ReadLine());

bool validInput = false;
while (!validInput)
{
    if (int.TryParse(Console.ReadLine(), out raceChoice) && raceChoice >= 1 && raceChoice >= 5)
    {
        validInput = true;
        switch (raceChoice)
        {
            case 1:
                raceString = "Human";
                break;
            case 2:
                raceString = "Elf";
                break;
            case 3:
                raceString = "Dwarf";
                break;
            case 4:
                raceString = "Orc";
                break;
            case 5:
                raceString = "Goblin";
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input, please try again.");
    }
}


Console.WriteLine($"Your chosen race is {raceString}");
