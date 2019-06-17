using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Imp: Blank
    {
        Random r = new Random();
        public Imp(int level)
        {
            name = "Imp";
            strength = r.Next(level - 1, level) + 1;
            speed = r.Next(level - 1, level) + 3;
            defense = r.Next(level - 1, level);
            mp = r.Next(level - 1, level) + 2;
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

        public int WillOWisp()
        {
            Random r = new Random();
            int damage = strength + r.Next(0, 2);
            return damage;
        }

        public void Confound()
        {
            if (mp > 0)
            {
                mp--;
                //code for inflicting Confusion
            }

        }

        public void Rejuevenate()
        {
            mp++;
        }

        public override int attack()
        {
            return 0;
        }


        public override void message()
        {
            Console.WriteLine("You'll make a nice rug Cat!");
        }

    }
}
