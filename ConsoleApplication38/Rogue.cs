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
            health = 15;
            strength = 5;
            defense = 0;
            speed = 5 + (level * 2);
            mp = 0;
        }
    }
}
            

