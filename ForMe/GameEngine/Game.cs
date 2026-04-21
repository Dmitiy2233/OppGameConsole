using ForMe.Models;

namespace ForMe.GameEngine;

public class Game
{
    private Combat _combat = new Combat();
    private string _playerName;

    public void Playing()
    {
        Character goblin = new Character("Goblin", 60, 10, 10);
        Character ork = new Character("Ork", 120, 30, 20);

        // Ask name only once
        if (string.IsNullOrWhiteSpace(_playerName))
        {
            while (true)
            {
                Console.WriteLine("What is your Name Traveller");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Name cannot be empty");
                    continue;
                }

                if (input.Length > 3 && input.Length < 50)
                {
                    _playerName = input;
                    break;
                }

                Console.WriteLine("Isn't valid name");
            }
        }

        Character hero = new Character(_playerName, 100, 20, 20);

        Console.WriteLine($"Hi traveler {_playerName}, fight with who do you want?");
        Console.WriteLine("1. Goblin");
        Console.WriteLine("2. Ork");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        switch (choice)
        {
            case 1:
                _combat.Fight(hero, goblin);
                break;

            case 2:
                _combat.Fight(hero, ork);
                break;

            default:
                Console.WriteLine("Wrong case try again");
                break;
        }
    }
}