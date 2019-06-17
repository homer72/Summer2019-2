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
            mp = 5 + Convert.ToInt32((level * 1.3));
            xp = 0;
            level = 0;
        }

        public override int attack()
        {
            return 0;
        }

        public void ViewStats()
        {
            Console.WriteLine("Health: {0}\nStrength: {1}\nDefense: {2}\nSpeed: {3}\nMP: {4}\n", health, strength, defense, speed, mp);
        }

        public void MageSkills()
        {
            Console.WriteLine("1. Fireball\n2. Recover\n3. Charge\n4. Wind Bullets\n5. Explosion\n6.Enhancement");
        }

        public void SkillInfo(int skill)
        {
            switch (skill)
            {
                case 1:
                    Console.WriteLine("Player launches a moderate damage fireball at the opponent, -2 MP.");
                    break;
                case 2:
                    Console.WriteLine("User heals their wounds. Restores 33% of max HP, -2 MP.");
                    break;
                case 3:
                    Console.WriteLine("User pauses to regain composure, +3 MP.");
                    break;
                case 4:
                    Console.WriteLine("Player launches bullets of wind at the opponent. Deals low damage but hits 2 to 5 times, -2 MP");
                    break;
                case 5:
                    Console.WriteLine("All remaining MP is used. Damage directly correlates with how much MP is consumed.");
                    break;
                case 6:
                    Console.WriteLine("User chants a spell to increase base strength by 10% temporarily. -1 MP");
                    break;
                default:
                    Console.WriteLine("That is not one of the Mage's skills.");
                    break;
            }
        }

        public int Fireball()
        {
            mp -= 2;
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 1)), Convert.ToInt32((strength * 1.5)));
            return damage;
        }

        public int Recover()
        {
            mp -= 2;
            return Convert.ToInt32(health * 1.33f);
        }

        public int Charge()
        {
            return mp += 3;
        }

        public int WindBullet()
        {
            int damage = 0;
            Random r = new Random();
            Random times = new Random();
            for (int i = 0; i < times.Next(2, 5); i++)
            {
                damage += r.Next(Convert.ToInt32((strength * 0.3)), Convert.ToInt32((strength * 0.35)));
            }
            mp -= 2;
            return damage;
        }

        public int Explosion()
        {
            int damage = mp * 2;
            mp -= mp;
            return damage;
        }

        public int Enhancement()
        {
            mp -= 1;
            strength += Convert.ToInt32(strength * 0.1);
            return strength;
        }

    }
}