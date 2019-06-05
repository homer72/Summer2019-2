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
            damage = r.Next(level - 1, level);
            if (damage <= 0)
            {
                damage = 1;
            }
          
            health = (r.Next(50, 100)*.1f) + level;
            xp = 3 * level;
        }

        
    }
}
//Did it work?  - M Engelbrecht

//M Engelbrecht Testing                  

//Please accept me into the project.  I NEED THIS
//just shutup and take my money.
//doh
// bugbear
// I'm here
// new line
//Testing another way to commit changes
//This commit was through VS
//andrew did this through VS
//doug did this in VS
