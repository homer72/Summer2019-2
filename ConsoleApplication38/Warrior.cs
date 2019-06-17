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
        public Warrior(string username)
        {
            health = 15 + (Convert.ToInt32(level * 1.15f));
            strength = 10 + (level * 2);
            defense = 5 + (Convert.ToInt32(level * 1.5f)); ;
            speed = 5 + (level);
            mp = 5 + (Convert.ToInt32(level * 0.85f));
            xp = 0;
            level = 0;
            name = username;

        }
       
        
        public override int attack()
        {
            
            int attack = (r.Next((r.Next(Convert.ToInt32(strength *.95f),(Convert.ToInt32(strength * 1.2f))))));
            return attack;//regular attack
        }
        public int Rage()
        {
            int rage = strength*2+defense/2;
          
            return rage; //Rage(multiplies strength by 2 but decreases defence by 50%)
        }

        public int Battlecry()
        {
            int buff = Convert.ToInt32((health + strength + defense + speed + mp) * .30f);
            return buff;
            // Battlecry( Increases stats by 30% for 2 turns)
        }
       public int Defend()
        {
            int def = Convert.ToInt32(defense * .30f);
            return def;
                // Defend( Increases defence stat by 30%)
        }

        public void getmoves(int skills)
        {
            attack();
            Defend();
            Rage();
            Battlecry();
        }
        // Weapons: 
        // Heavy Armor:
        // items:


        public override void message()
        {

        }




    }
    }

            

