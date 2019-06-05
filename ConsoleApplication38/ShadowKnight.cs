using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class ShadowKnight:Blank
    {
        Random r = new Random();
        public ShadowKnight(int level)
        {
            name = "ShadowKnight";
            strength = r.Next(level - 1, level) + 3;
            speed = r.Next(level - 1, level) + 1;
            defense = r.Next(level - 1, level) + 4;
            mp = r.Next(level - 1, level) + 2;
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
            xp = 5 * level;                                 //setting xp
        }

        public void ShieldWall()
        {
            //insert code

        }

    }
}
