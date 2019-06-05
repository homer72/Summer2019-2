using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Rogue : Blank
    {
        public Rogue()
        {
            string job_name = "Rouge";
            health = 15 + (level);
            strength = 5 + (level);
            defense = 5 + (Convert.ToInt32(level * 0.85f));
            speed = 5 + (level * 2);
            mp = 5 + (level);
        }
    }
}
            

