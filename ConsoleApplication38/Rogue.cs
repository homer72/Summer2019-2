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

        public void ViewStats()
        {
            Console.WriteLine("Health: {0}\nStrength: {1}\nDefense: {2}\nSpeed: {3}\nMP: {4}\n", health, strength, defense, speed, mp);
        }
        
        public void RougeSkills()
        {
            Console.WriteLine("1. Vital Strike\n2. Backstab\n3. Sprint\n4. Snipe\n5. Tipped Dagger\n6.Stealth");
        }

        public void SkillInfo(int skill)
        {
            switch (skill)
            {
                case 1:
                    Console.WriteLine("Default rouge attack. Deals moderate damage.");
                    break;
                case 2:
                    Console.WriteLine("Deals low to moderate damage. Deals additional damage based on 20% of user's speed stat.");
                    break;
                case 3:
                    Console.WriteLine("Increases speed stat by 30% for the next 3 or 4 turns.");
                    break;
                case 4:
                    Console.WriteLine("Long ranged bow attack that varies from low to high damage.");
                    break;
                case 5:
                    Console.WriteLine("Player throws a poison-tipped dagger that deals low damage, poisons 100%, and dazes 10%.");
                    break;
                case 6:
                    Console.WriteLine("Defense is increased by 40% of current MP for 4 to 5 turns");
                    break;
                default:
                    Console.WriteLine("That is not one of the Rouge's skills.");
                    break;
            }
        } 

        public int VitalStrike()
        {
            //Default rouge attack
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 0.9)), Convert.ToInt32((strength * 1.1)));
            return damage;
        }

        public int Backstab()
        {
            //Uses strength for damage. 20% of speed is added to total damage dealt. Deals extra damage if target is dazed
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 0.7)), Convert.ToInt32((strength * 1))) + Convert.ToInt32((speed *.2));
            return damage;
        }

        public int Sprint()
        {
            //Increases speed stat by 30% for the next 3 or 4 turns
            speed += Convert.ToInt32(speed * 1.3);
            return speed;
        }

        public int Snipe()
        {
            //Long ranged bow attack that varies in damage and deals extra damage to Imps.
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 0.6)), Convert.ToInt32((strength * 1.4)));
            return damage;
        }

        public int TippedDagger()
        {
            //Player throws a poison-tipped dagger that deals low damage, poisons 100%, and dazes 10%.
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 0.55)), Convert.ToInt32((strength * .8)));
            return damage;
        }
        
        public int Stealth()
        {
            //Defense is increased by 40% of current MP for 4 to 5 turns
            mp -= 2;
            defense += Convert.ToInt32(mp * 0.4);
            return defense;
        }

    }
}
            

