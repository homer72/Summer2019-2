using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Rogue : Blank
    {
        public string job_name = "Rogue";
        public Rogue(string name)
        {
            health = 15 + (level);
            strength = 5 + (level);
            defense = 5 + (Convert.ToInt32(level * 0.85f));
            speed = 5 + (level * 2);
            mp = 5 + (level);
            xp = 0;
            level = 0;
            this.name = name;
        }

        public override int attack()
        {
            int damage = 0;
            int choice = -1;
            bool end = false;  //variable that determines when turn is over
            while (!end) //loop that starts the turn
            {
                bool choose_phase = false;  //variable that determines the end of the 'pick a skill' phase
                RogueSkills();
                Console.Write("7. (Skill info)\n8. (Player stats)\n");

                Console.WriteLine("Choose a skill from above: ");
                while (!choose_phase)  //loop that starts the phase 'pick a skill' phase
                {
                    string input = Console.ReadLine();
                    try
                    {
                        if (Convert.ToInt32(input) >=1 && Convert.ToInt32(input) <= 7)
                        {
                            choice = Convert.ToInt32(input);
                        }
                        choose_phase = true;
                    }
                    catch
                    {
                        RogueSkills();
                        Console.WriteLine("Please type a number corresponding to the appropriate skill: ");
                    }
                }

                switch (choice)
                {
                    case 1:
                        damage = VitalStrike();
                        end = true;
                        break;
                    case 2:
                        damage = Backstab();
                        end = true;
                        break;
                    case 3:
                        speed = Sprint();
                        end = true;
                        break;
                    case 4:
                        damage = Snipe();
                        end = true;
                        break;
                    case 5:
                        damage = TippedDagger();
                        end = true;
                        break;
                    case 6:
                        defense = Stealth();
                        end = true;
                        break;
                    case 7:  //Brings the user to look at what each skill does
                        SkillInfo();
                        break;
                    case 8:
                        ViewStats();
                        break;
                    default:
                        Console.WriteLine("Something went wrong when picking a skill. You shouldn't be able to see this message.");
                        break;
                }
            }
            return damage;
        }

        public void updateStats(int damage, int HP, int Str, int Def, int Spe, int MP)
        {
            health = HP - damage;
            strength = Str;
            defense = Def;
            speed = Spe;
            mp = MP;
        }

        public void ViewStats()
        {
            Console.WriteLine("Health: {0}\nStrength: {1}\nDefense: {2}\nSpeed: {3}\nMP: {4}\n", health, strength, defense, speed, mp);
        }
        
        public void RogueSkills()
        {
            Console.WriteLine("\n1. Vital Strike\n2. Backstab\n3. Sprint\n4. Snipe\n5. Tipped Dagger\n6. Stealth");
        }

        public void SkillInfo()
        {
            int skill = -1;
            RogueSkills();
            Console.Write("7. (Quit)\n");
            Console.WriteLine("Pick a skill you would like to know more about:");
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    if (Convert.ToInt32(input) >= 1 && Convert.ToInt32(input) <= 7)
                    {
                        skill = Convert.ToInt32(input);
                    }
                    break;
                }
                catch
                {
                    RogueSkills();
                    Console.Write("7. (Quit)\n");
                    Console.WriteLine("Please type a number corresponding to the appropriate skill: ");
                }
            }

            switch (skill)
            {
                case 1:
                    Console.WriteLine("Vital Strike: The default rogue attack. Deals moderate damage.");
                    break;
                case 2:
                    Console.WriteLine("Backstab: Deals low to moderate damage. Deals additional damage based on 20% of user's speed stat.");
                    break;
                case 3:
                    Console.WriteLine("Sprint: Increases speed stat by 30% for the next 3 or 4 turns.");
                    break;
                case 4:
                    Console.WriteLine("Snipe: Long ranged bow attack that varies from low to high damage.");
                    break;
                case 5:
                    Console.WriteLine("Tipped Dagger: Player throws a poison-tipped dagger that deals low damage, poisons 100%, and dazes 10%.");
                    break;
                case 6:
                    Console.WriteLine("Stealth: Defense is increased by 40% of current MP for 4 to 5 turns");
                    break;
                case 7:
                    Console.WriteLine("Choose a skill: ");
                    break;
                default:
                    Console.WriteLine("That is not one of the Rouge's skills.");
                    break;
            }
        } 

        public int VitalStrike()
        {
            //Default rogue attack
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 0.9)), Convert.ToInt32((strength * 1.1)));
            Console.WriteLine("{0} used VitalStrike, dealing {1} damage!", name, damage);
            return damage;
        }

        public int Backstab()
        {
            //Uses strength for damage. 20% of speed is added to total damage dealt. Deals extra damage if target is dazed
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 0.7)), Convert.ToInt32((strength * 1))) + Convert.ToInt32((speed *.2));
            Console.WriteLine("{0} used Backstab, dealing {1} damage!", name, damage);
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
            Console.WriteLine("{0} used Snipe, dealing {1} damage!", name, damage);
            return damage;
        }

        public int TippedDagger()
        {
            //Player throws a poison-tipped dagger that deals low damage, poisons 100%, and dazes 10%.
            Random r = new Random();
            int damage = r.Next(Convert.ToInt32((strength * 0.55)), Convert.ToInt32((strength * .8)));
            Console.WriteLine("{0} used TippedDagger, dealing {1} damage!", name, damage);
            return damage;
        }
        
        public int Stealth()
        {
            //Defense is increased by 40% of current MP for 4 to 5 turns
            mp -= 2;
            defense += Convert.ToInt32(mp * 0.4);
            return defense;
        }

        public override void message()
        {

        }
    }
}
            

