﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Mage : Blank
    {
        public string job_name = "Magician";
        public Mage()
        {
            health = 15 + (Convert.ToInt32(level * 0.85f));
            strength = 5 ;
            defense = 5 + (Convert.ToInt32(level*0.8f));
            speed = 5 + (level);
            mp = 5 + (level * 2);
        }
    }
}
