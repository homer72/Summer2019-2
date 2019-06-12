using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Mage : Blank
    {
        public string job_name = "Mage";
        public Mage()
        {
            health = 15 + (Convert.ToInt32(level * 0.85f));
            strength = 5 + (level);
            defense = 5 + (level);
            speed = 5 + (level);
            mp = 5 + (level * 2);
            xp = 0;
            level = 0;
        }

        public void Fireball()
        {
            mp -= 2;
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 0.9)), Convert.ToInt32((strength * 1.1)));
            //Missing code that adds chance of burn status
        }

        public int Recover()
        {
            mp -= 1;
            return Convert.ToInt32(health * 1.33f);
        }

        public int Charge()
        {
            return mp += 3;
        }
    }
}
