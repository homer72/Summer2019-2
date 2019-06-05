﻿using System;
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
            health = 15 + (Convert.ToInt32(level * 0.85f));
            strength = 5 + (level);
            defense = 5 + (level);
            speed = 5 + (level);
            mp = 5 + (level * 2);
        }
    }
}
