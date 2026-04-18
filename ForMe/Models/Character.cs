namespace ForMe.Models;

public class Character
{
    public string Name { get; private set; }
    public int Health { get; set; }
    public int Damage { get; private set; }
    public int Heal { get; private set; }

    public Character(string name, int health, int damage, int heal)
    {
        Name = name;
        Health = health;
        Damage = damage;
        Heal = heal;
    }
}