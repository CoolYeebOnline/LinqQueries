using System.Collections.Generic;
using System.Linq;
using System;


namespace LinqQuery
{

    class Enemy
    {
        public string name { get; set; }
        public int health { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Enemys = new List<Enemy>()
            {
                new Enemy {name="Filip the fierce", health = 75 },
                new Enemy {name="Dadam the dastardly", health = 80 },
                new Enemy {name="Hari the breaker of walls", health = 95 },
                new Enemy {name="Lord Dallon THE Daring", health = 1000 }
            };

            IEnumerable<Enemy> trashmobs = from e in Enemys where e.name.Contains("the") select e;
            IEnumerable<Enemy> bossmobs = from e in Enemys where e.health > 999 select e;

            Console.WriteLine("Trash mobs are: ");
            foreach(Enemy e in trashmobs)
            {
                Console.WriteLine("\t" + e.name);
                Console.WriteLine("\tHealth" + e.health); 
            }

            Console.WriteLine("Boss mobs are: ");
            foreach(Enemy e in bossmobs)
            {
                Console.WriteLine("\t" + e.name);
                Console.WriteLine("\tHealth" + e.health);
            }

            Console.ReadKey();
        }
    }
}
