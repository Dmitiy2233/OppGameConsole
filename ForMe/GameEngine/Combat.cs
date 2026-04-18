using ForMe.Models;

namespace ForMe.GameEngine;

public class Combat
{
    private Random rnd = new Random();
    private bool Isfighting = true;
    public void Fight(Character Hero, Character Enemy)
    {
        
        while (Isfighting)
        {
            Console.WriteLine("You have 2 options (type number for choose)");
            Console.WriteLine("1. Atack");
            Console.WriteLine("2. Heal");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Enemy has been atacked");
                    Enemy.Health -= Hero.Damage;
                    break;
                
                case 2:
                    Console.WriteLine($"{Hero.Name} heals");
                        Hero.Health += Hero.Heal;
                    break;
                
                default:
                    continue;
            }
            
            
                int action = rnd.Next(0, 2); // 0 or 1

                switch (action)
                {
                    case 0:
                        Console.WriteLine($"{Enemy.Name} attacks!");
                        Hero.Health -= Enemy.Damage;
                        break;

                    case 1:
                        Console.WriteLine($"{Enemy.Name} heals!");
                        Enemy.Health += Enemy.Damage;
                        break;
                }
            
            
            if (Hero.Health <= 0)
            {
                Console.WriteLine($"{Enemy.Name} got the win");
                Isfighting = false;
            }

            if (Enemy.Health <= 0)
            {
                Console.WriteLine($"{Hero.Name} got the win");
                Isfighting = false;
            }
        }
        
    }
    
}