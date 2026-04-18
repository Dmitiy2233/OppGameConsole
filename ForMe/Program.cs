using ForMe.Models;

class Program
{
    static void Main()
    {
        Character Goblin = new Character("Goblin", 60, 10, 10);
        Console.WriteLine("What is your Name Traveller");
        string input = Console.ReadLine();
        Character hero = new Character(input, 100, 20, 20);
        
    }
}