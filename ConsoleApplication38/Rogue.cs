using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Rogue : Blank
    {
        public string job_name = "Rouge";
        public Rogue()
        {
            health = 15 + (level);
            strength = 5 + (level);
            defense = 5 + (Convert.ToInt32(level * 0.85f));
            speed = 5 + (level * 2);
            mp = 5 + (level);
            xp = 0;
            level = 0;
        }

        
        public void VitalStrike()
        {
            //Deals damage and applies bleed. (possible extra crit chance, get group consensus)
        }

        public void Backstab()
        {
            //Uses strength for damage. 15% of speed is added to total damage dealt. Deals extra damage if target is dazed
        }

        public void Sprint()
        {
            //Increases speed stat by 30% for the next 3 or 4 turns
        }

        public int Snipe()
        {
            //Long ranged bow attack that deals extra damage to Imps.
        }

        public void TippedDagger()
        {
            //player throws a poison-tipped dagger that deals low damage, poisons 100%, and dazes 10%.
        }
        
        public void Stealth()
        {
            //Defense is increased by 20% of current MP for 4 to 5 turns
        }

    }
}
            

