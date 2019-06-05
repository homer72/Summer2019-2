using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Vampire:Blank
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

            health = (r.Next(50, 100) * .1f) + level;         //setting health
            xp = 3 * level;                                 //setting xp
        }



    }
}
