using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Warrior : Blank
    {
        public Warrior()
        {
            string job_name = "Warrior";
            health = 15 + (Convert.ToInt32(level * 1.15f));
            strength = 5 + (level * 2);
            defense = 0;
            speed = 5;
            mp = 5 + (Convert.ToInt32(level * 0.85f));
        }
    }
}
            

