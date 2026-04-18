using ForMe.Models;

namespace ForMe.GameEngine;

public class Game
{
    public void Playing() 
    {
        Character Goblin = new Character("Goblin", 60, 10, 10);
        Console.WriteLine("What is your Name Traveller");
        string input = Console.ReadLine();
        Character hero = new Character(input, 100, 20, 20);
        Console.WriteLine("Hi traveler fight with who do you want?");
        Console.WriteLine("1. Goblin");
        Console.WriteLine("2. Ork");
        int choice = int.Parse(Console.ReadLine());

    }
}