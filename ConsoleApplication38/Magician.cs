using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Magician : Blank
    {
        public Magician()
        {
            string job_name = "Magician";
            health = 0;
            strength = 0;
            defense = 0;
            speed = 0;
            mp = 5 + (level * 2);
        }
    }
}
