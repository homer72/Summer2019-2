using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class BugBear:Blank
    {
        Random r = new Random();
        public BugBear(int level)
        {
            name = "BugBear";
            strength = r.Next(level - 1, level);
            if (strength <= 0)
            {
                strength = 1;
            }
          
            health = (r.Next(50, 100)*.1f) + level;
            xp = 3 * level;
        }

        
    }
}

