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
            health = 0;
            strength = 5 + (level * 2);
            defense = 0;
            speed = 0;
            mp = 0;

        }

    }
}
