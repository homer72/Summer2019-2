using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Warrior : Blank
    {
        public string job_name = "Warrior";
        Random r = new Random();
        public Warrior()
        {
            health = 15 + (Convert.ToInt32(level * 1.15f));
            strength = 10 + (level * 2);
            defense = 5 + (Convert.ToInt32(level * 1.5f)); ;
            speed = 5 + (level);
            mp = 5 + (Convert.ToInt32(level * 0.85f));
            xp = 0;
            level = 0;

        }
       
        
        public int attack()
        {
            Random r = new Random();
            int attack = strength;
            return attack;//regular attack
        }
        public int Rage()
        {
            Random r = new Random();
            int rage = strength*2+defense/2;
            return rage; //Rage(multiplies strength by 2 but decreases defence by 50%)
        }

        public void Battlecry()
        {
            // Battlecry( Increases stats by 30% for 2 turns)
        }
       public void Defend()
        {
            // Defend( Increases defence stat by 30%)
        }
        
        // Weapons: 
        // Heavy Armor:
        // items:







    }
    }

            

