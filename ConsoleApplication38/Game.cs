using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace ConsoleApplication38
{
    class Game
    {
        static void Main(string[] args)
        {
            

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\music.wav";
            player.Play();

            Game obj = new Game();
            obj.Menu();

            string userName = obj.Intro();
            obj.TrainingLevel(userName);


            Console.ReadKey();
        }

        void Menu()
        {
            Console.WriteLine("                                                Press 'Enter' To Play                                          ");
            Console.ReadLine();
            Console.WriteLine("██████╗ ██╗   ██╗███╗   ██╗ ██████╗ ███████╗ ██████╗ ███╗   ██╗    ██████╗ ██╗██╗   ██╗███████╗██████╗ ███████╗");
            Console.WriteLine("██╔══██╗██║   ██║████╗  ██║██╔════╝ ██╔════╝██╔═══██╗████╗  ██║    ██╔══██╗██║██║   ██║██╔════╝██╔══██╗██╔════╝");
            Console.WriteLine("██║  ██║██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██║   ██║██╔██╗ ██║    ██║  ██║██║██║   ██║█████╗  ██████╔╝███████╗");
            Console.WriteLine("██║  ██║██║   ██║██║╚██╗██║██║   ██║██╔══╝  ██║   ██║██║╚██╗██║    ██║  ██║██║╚██╗ ██╔╝██╔══╝  ██╔══██╗╚════██║");
            Console.WriteLine("██████╔╝╚██████╔╝██║ ╚████║╚██████╔╝███████╗╚██████╔╝██║ ╚████║    ██████╔╝██║ ╚████╔╝ ███████╗██║  ██║███████║");
            Console.WriteLine("╚═════╝  ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚═╝  ╚═══╝    ╚═════╝ ╚═╝  ╚═══╝  ╚══════╝╚═╝  ╚═╝╚══════╝");
        }
        

        string Intro()
        {
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome, Dungeon Diver! Behold a strategic turn based game that explores through a vast dungeon with doors to open and ");
            Console.WriteLine("rooms to explore. You are a Dungeon Diver, a unique adventurer whose purpose is to collect items, fight, level up and");
            Console.WriteLine("do be advised monsters exist within this realm and it's your job to take care of those monsters by any means necessary");
            Console.WriteLine("to level up and become stronger.");



            Console.WriteLine();
            Console.WriteLine("What is your name adventurer? ");
            string userName = Console.ReadLine();
            return userName;
        }


        void TrainingLevel(string userName) //Introductory Level
        {
            Blank ob = null;

            


            Console.WriteLine("Welcome " + userName + " I will be your teacher, Chiron.  My job here is to make sure you are ready to begin your great adventure.");
            Console.WriteLine("Firstly, every hero needs a weapon.  I will gift you a weapon now to start your adventure.");
            Console.WriteLine("But before that, I must ask, what style of adventurer are you?  Mage?  Rogue?  Or Warrior?");
            string playerClass = Console.ReadLine();
            //using a placeholder for the player class.  Chiron is going to give them a weapon depending on which class they use.


            if ( playerClass.ToUpper() == "MAGE")
            {
                ob = new Mage();
                Console.WriteLine("Ah, a magican?  I've trained a few of those in my day.");
                Console.WriteLine("I think I have some weapons for you to choose lying around somewhere... ");

                Console.WriteLine("Take your pick, hero:  1: Wand.  2: Staff.  3: Tome.");
                int ans = Convert.ToInt32(Console.ReadLine());

                {
                    if (ans == 1)
                    {
                        string itemTemp = "Wand";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp); 
                    }
                    else if (ans == 2)
                    {
                        string itemTemp = "Staff";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp);
                    }
                    else if (ans == 3)
                    {
                        string itemTemp = "Tome";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp);
                    }
                }
            }


            if (playerClass.ToUpper() == "WARRIOR")
            {
                ob = new Warrior();
                Console.WriteLine("A Warrior, eh?  You may know a guy I trained back in the day, I think his name was Hercules");
                Console.WriteLine("I think I have some weapons for you to choose lying around somewhere... ");

                Console.WriteLine("Take your pick, hero:  1: Sword.  2: Axe.  3: Mace.");
                int ans = Convert.ToInt32(Console.ReadLine());

                {
                    if (ans == 1)
                    {
                        string itemTemp = "Sword";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp);
                    }
                    else if (ans == 2)
                    {
                        string itemTemp = "Axe";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp);
                    }
                    else if (ans == 3)
                    {
                        string itemTemp = "Mace";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp);
                    }
                }
            }

            if (playerClass.ToUpper() == "ROGUE")
            {
                ob = new Rogue();
                Console.WriteLine("Ah, I haven't trained as many Rogues, but I'm sure I can still teach you a thing or two");
                Console.WriteLine("I think I have some weapons for you to choose lying around somewhere... ");

                Console.WriteLine("Take your pick, hero:  1: Dagger.  2: Bow.  3: Poisoned Sword.");
                int ans = Convert.ToInt32(Console.ReadLine());

                {
                    if (ans == 1)
                    {
                        string itemTemp = "Dagger";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp);
                    }
                    else if (ans == 2)
                    {
                        string itemTemp = "Bow";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp);
                    }
                    else if (ans == 3)
                    {
                        string itemTemp = "Poisoned Sword";
                        ob.inventory[0].inventory[0] = itemTemp;
                        Console.WriteLine("Item Added: " + itemTemp);
                    }
                }
            }











            Console.WriteLine("Every adventure starts with a trusty weapon.");
            Console.WriteLine("To Access your Inventory at any time, type in 'inv' ");
            Console.WriteLine("Try it now.");
            string userAns = Console.ReadLine();
            if(userAns == "inv")
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(ob.inventory[i]);
                }
                
            }
            else
            {
                Console.WriteLine("Ok but remember how to do this later.");
            }
            Console.WriteLine("Excellent! You're a quick learner, I can already tell you'll be one of the best Dungeon Divers out there! ");
            Console.WriteLine("I'll explain two more things and you'll be on your way! Whenever you go through the dungeon you'll get the");
            Console.WriteLine("choice of picking one of three doors with three different outcomes, a monster, a hidden item, or nothing.");
            Console.WriteLine("Finally its time I tought you how to fight...");
            //start fight
            master(ob);




        }



        public void master(Blank ob)

            /* Potential flaw in this method of monster creation is that a NEW monster is created at every battle.
             * 
             *  Possible solution - generate monsters at game beginning and call them during the battle. This allows monster
             *  stats to be updated during battles and follows the monster through the game. **Downside - Need to pass in player
             *  stats each battle to determine monster stats effectively making saving the monster stats pointless.
             *  
             *  Alternate solution - Leave as is and ganerate new monster each time sinch monster characteristics are based on 
             *  player stats. Downside - Potentially LOTS of monsters created if a long game. However, no need to store monster
             *  stats if new ones are generated each time.
             *  
             *  Thoughts?
             */
        {
            // ******************************Determines which Monster 
            Random r = new Random();
            int rNum = r.Next(1, 6);
            Blank monster = null;            

            if (rNum == 1)
            {
                monster = new Vampire(ob.level);
            }
            if (rNum == 2)
            {
                monster = new ShadowKnight(ob.level);
            }
            if (rNum == 3)
            {
                monster = new Imp(ob.level);
            }
            if (rNum == 4)
            {
                monster = new Goblin(ob.level);
            }
            if (rNum == 5)
            {
                monster = new DiamondDog(ob.level);
            }
            if (rNum == 6)
            {
                monster = new BugBear(ob.level);
            }
            //*********************************************************************



            bool battle_over = false;
            while (battle_over != true)
            {
                //checking to see who's speed is higher
                if (ob.speed > monster.speed)
                { //code for player to attack first
                    monster.health -= ob.attack(); // need to make all monster attacks named "Attack()"
                }

                else if (ob.speed == monster.speed)
                { //code for speed being a tie
                    Random num = new Random();
                    int coin = num.Next(1, 2);
                    if (coin == 1)
                    {
                        monster.attack();
                    }
                    else
                        ob.attack();
                }

                else
                { //code for enemy to go first
                    monster.attack();


                }
            }



        }


    }
}

