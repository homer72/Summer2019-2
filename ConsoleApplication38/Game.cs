using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Game
    {
        static void Main(string[] args)
        {
            
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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome Dungeon Diver! Behold a strategic turn based game that explores through a vast dungeon with doors to open and ");
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
            Rogue rog = new Rogue();
            Item ob = new Item();

            


            Console.WriteLine("Welcome " + userName + " I will be your teacher, Chiron.  My job here is to make sure you are ready to begin your great adventure.");
            Console.WriteLine("Firstly, every hero needs a weapon.  I will gift you a weapon now to start your adventure.");
            Console.WriteLine("But before that, I must ask, what style of adventurer are you?  Mage?  Rogue?  Or Warrior?");
            string playerClass = Console.ReadLine();
            //using a placeholder for the player class.  Chiron is going to give them a weapon depending on which class they use.

            if ( playerClass.ToUpper() == "MAGE")
            {
                Console.WriteLine("Ah, a magican?  I've trained a few of those in my day.");
                Console.WriteLine("I think I have some weapons for you to choose lying around somewhere... ");
                Console.WriteLine("Take your pick, hero:  1: Wand.  2: Staff.  3: Tome.");
                int ans = Convert.ToInt32(Console.ReadLine());
                
                if (ans == 1)
                {
                    string itemTemp = "Wand";
                    ob.inventory[0] = itemTemp;
                    Console.WriteLine("Item Added: " + itemTemp);
                }
                else if (ans == 2)
                {
                    string itemTemp = "Staff";
                    ob.inventory[0] = itemTemp;
                    Console.WriteLine("Item Added: " + itemTemp);
                }
                else if (ans == 3)
                {
                    string itemTemp = "Tome";
                    ob.inventory[0] = itemTemp;
                    Console.WriteLine("Item Added: " + itemTemp);
                }



            }

            if (playerClass == "WARRIOR")
            {
                Console.WriteLine("Item Added:  'Rusty Metal Sword' ");
                ob.inventory[0] = "Rusty Metal Sword";
            }

            if (playerClass == "ROGUE")
            {
                Console.WriteLine("Item Added:  'Rusty Metal Daggers' ");
                ob.inventory[0] = "Rusty Metal Daggers";
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


            

        }



        public void Master(int player_spd, int enemy_spd)
        {
            bool battle_over = false;

            while (battle_over != true)
            {
                //checking to see who's speed is higher
                if (player_spd > enemy_spd)
                {
                    //code for player to attack first


                }
                else if (player_spd == enemy_spd)
                {

                    //code for speed being a tie

                }
                else
                {

                    //code for enemy to go first


                }
            }



        }


    }
}

