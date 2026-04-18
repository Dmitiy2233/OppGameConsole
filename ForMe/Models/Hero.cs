namespace ForMe.Models;

public class Hero
{
    public string Name;
    public int Health;
    public int Damage;
    public void HeroIntr()
    {
        Console.WriteLine("What is your name?");
        string input = Console.ReadLine();
        Name = input;
        Health = 100;
        Damage = 20;
    }
}