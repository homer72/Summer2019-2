using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Goblin: Blank
    {
        Random r = new Random();
        public Goblin(int level)
        {
            name = "Goblin";
            strength = r.Next(level - 1, level) + 2;
            speed = r.Next(level - 1, level) + 2;
            defense = r.Next(level - 1, level);
            mp = r.Next(level - 1, level);
            if (strength <= 0)
            {
                strength = 1;
            }

            if (speed <= 0)
            {
                speed = 1;
            }

            if (defense <= 0)
            {
                defense = 1;
            }

            if (mp <= 0)
            {
                mp = 1;
            }

            health = (r.Next(50, 100) * .1f) + level;
            xp = 2 * level;
        }
        public override int attack()
        {
            Console.WriteLine("Aha!  Taste these claws sucka!");
            Console.WriteLine("Goblin did 3 Damage!");
            return 3;
        }

        public override void message()
        {
            Console.WriteLine("Do you feel like dying today?  I think you do!!!!  Wahahahahaha");
        }

    }
}
