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
        public Warrior()
        {
            health = 15 + (Convert.ToInt32(level * 1.15f));
            strength = 5 + (level * 2);
            defense = 5 + (level);
            speed = 5 + (level);
            mp = 5 + (Convert.ToInt32(level * 0.85f));
            xp = 0;
            level = 0;

        }
        
         // Attack (Regular strength stat )
         //Rage(multiplies strength by 2 but decreases defence by 50%)
         // Battlecry( Increases stats by 30% for 2 turns)
         // Defend( Increases defence stat by 30%)
         //
        
         // Weapons: 
        
      
            





         }
    }

            

