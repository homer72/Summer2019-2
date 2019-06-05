using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class DiamondDog: Blank
    {
        Random r = new Random();
        public DiamondDog(int level)
        {
            name = "Diamond Dog";
            strength = r.Next(level - 1, level);
            speed = r.Next(level - 1, level) + 1;
            defense = r.Next(level - 1, level) + 3;
            mp = r.Next(level - 1, level) + 1;
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
            xp = 3 * level;

            public void Fortify()
            {
                defense += 2;
            }

        }
    }
}
