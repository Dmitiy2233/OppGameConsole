using System.Reflection.Metadata.Ecma335;
using ForMe.Models;

namespace ForMe.GameEngine;

public class Game
{
    private Combat combat = new Combat();
    
    public void Playing() 
    {
        Character goblin = new Character("Goblin", 60, 10, 10);
        Character ork = new Character("Ork", 120, 30, 20);
        
        Console.WriteLine("What is your Name Traveller");
        string input = Console.ReadLine();
        Character hero = new Character(input, 100, 20, 20);
        Console.WriteLine("Hi traveler fight with who do you want?");
        Console.WriteLine("1. Goblin");
        Console.WriteLine("2. Ork");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                combat.Fight(hero, goblin);
                break;
            
            case 2:
                combat.Fight(hero, ork);
                break;
            
            default:
                Console.WriteLine("Wrong case try again");
                return;
        }

    }
}