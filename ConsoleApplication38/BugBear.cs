﻿using System;
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
            strength = r.Next(level - 1, level) + 3;
            speed = r.Next(level - 1, level) + 1;
            defense = r.Next(level - 1, level) + 2;
            mp = r.Next(level - 1, level);
            if (strength <= 0)                               //if zero set to 1
            {
                strength = 1;
            }
            if (speed <= 0)                                 //if zero set to 1
            {
                speed = 1;
            }
            if (defense <= 0)                               //if zero set to 1
            {
                defense = 1;
            }
            if (mp <= 0)                                    //if zero set to 1
            {
                mp = 1;
            }

            health = (r.Next(50, 100)*.1f) + level;         //setting health
            xp = 3 * level;                                 //setting xp
        }

        public int MightyBlow()                             //a more powerful attack method
        {
            Random r = new Random();
            int damage = strength + r.Next(1, 5);
            return damage;

        }
        public override int attack()                            //basic attack method
        {
            Random r = new Random();
            int damage = strength;
            return damage;

        }
        public void Enrage()
        {
            if (mp > 0)
            {
                mp--;
                strength += 2;
                defense -= 1;
                //missing code to handle turns for duration
            }

        }
        public override void message() {

            Console.WriteLine("Me Bugbear! Me half-bear, half-bug, and 100% Awesome!");


        }


    }
}

