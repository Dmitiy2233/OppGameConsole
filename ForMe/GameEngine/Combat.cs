using ForMe.Models;

namespace ForMe.GameEngine;

public class Combat
{
    private Random _rnd = new Random();
    private bool _isfighting = true;
    public void Fight(Character hero, Character enemy)
    {
        
        while (_isfighting)
        {
            Console.WriteLine("=== Fight started ===");
            Console.WriteLine(($"Hero Hp: {hero.Health}"));
            Console.WriteLine(($"{enemy.Name} Hp: {enemy.Health}"));
            Console.WriteLine("1. Atack");
            Console.WriteLine("2. Heal");
            int input = int.Parse(Console.ReadLine() ?? "");

            switch (input)
            {
                case 1:
                    Console.WriteLine("Enemy has been atacked");
                    enemy.Health -= hero.Damage;
                    break;
                
                case 2:
                    Console.WriteLine($"{hero.Name} heals");
                        hero.Health += hero.Heal;
                    break;
                
                default:
                    continue;
            }
            
            
                int action = _rnd.Next(0, 2); // 0 or 1

                switch (action)
                {
                    case 0:
                        Console.WriteLine($"{enemy.Name} attacks!\n");
                        hero.Health -= enemy.Damage;
                        break;

                    case 1:
                        Console.WriteLine($"{enemy.Name} heals!\n");
                        enemy.Health += enemy.Damage;
                        break;
                }
            
            
            if (hero.Health <= 0)
            {
                Console.WriteLine($"{enemy.Name} got the win");
                _isfighting = false;
            }

            if (enemy.Health <= 0)
            {
                Console.WriteLine($"{hero.Name} got the win");
                _isfighting = false;
            }
        }
        
    }
    
}