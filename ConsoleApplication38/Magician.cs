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
            health = 15 + (level * 0.85f);
            strength = 5;
            defense = 0;
            speed = 5;
            mp = 5 + (level * 2);
        }
    }
}
