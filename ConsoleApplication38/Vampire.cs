using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Vampire : Blank
    {
        Random r = new Random();
        public Vampire(int level)
        {
            name = "Vampire";
            strength = r.Next(level - 1, level) + 2;
            speed = r.Next(level - 1, level) + 2;
            defense = r.Next(level - 1, level) + 1;
            mp = r.Next(level - 1, level) + 3;
            if (strength <= 0)                               //if zero set to 1
            {
                strength = 1;
            }
            if (speed <= 0)                                 //if zero set to 1
            {
                speed = 1;
            }
            if (defense <= 0)                               //if zero set to 1
            {
                defense = 1;
            }
            if (mp <= 0)                                    //if zero set to 1
            {
                mp = 1;
            }

            health = (r.Next(50, 100) * .1f) + level;       //setting health
            xp = 4 * level;                                 //setting xp

        }

        public int DrainHealth()                            //steal player health to heal self
        {

            Random r = new Random();
            int damage = strength + r.Next(1, 3);
            health += (damage/2);
            return damage;

        }
        public override int attack()                            //basic attack method
        {
            Random r = new Random();
            int damage = strength;
            return damage;

        }
        public void ObscuringMist()
        {
            if (mp > 0)
            {
                mp--;
                defense += 2;
                //missing code to handle turns for duration
            }

        }
        public void message()
        {

            Console.WriteLine("Two!, two bats! aha aha aha aha, I am Count CoCo Fang!");






        }


    }
}
