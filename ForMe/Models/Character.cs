namespace ForMe.Models;

public class Character
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }

    public Character(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
}