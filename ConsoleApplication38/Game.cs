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

           
            string userName = obj.Intro();
            obj.TrainingLevel(userName);

            
            Console.ReadKey();
        }


         

        string Intro()
        {
            Console.WriteLine("Welcome to Dungeon Divers! A strategic turn based game that explores through a vast dungeon with doors to open and roomsto explore. Be advised monsters exist within the game and it's your job to take care of those monsters by any means");
            Console.WriteLine("necessary to level up and become stronger.Your goal is to collect items, by fighting, level up and");
            




            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();
            return userName;
        }


        void TrainingLevel(string userName) //Introductory Level
        {
            
            Item ob = new Item();


            Console.WriteLine("Welcome " + userName + " I will be your teacher, Chiron.  My job here is to make sure you are ready to begin your Great Adventure.");
            Console.WriteLine("Firstly, every hero needs a weapon.  I will gift you a weapon now to start your adventure.");
            //using a placeholder for the player class.  Chiron is going to give them a weapon depending on which class they use.
            Console.WriteLine("But first, tell me your attack style?  Are you a Mage?  A Warrior?  Or are you a Rogue?");
            string playerClass = Console.ReadLine();
            

            if ( playerClass.ToUpper() == "MAGE")
            {
                Console.WriteLine("Ah, so you're a mage?  I've trained a few mages in my lifetime.");
                Console.WriteLine("I have a few weapons that might interest you.  Pick one of the three.");
                Console.WriteLine("1: 'Wand.' 2: 'Staff.' 3: 'Tome.' ");
                int ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 1)
                {
                    string item1 = "Wand";
                    Console.WriteLine("Item Added: " + item1);
                    ob.inventory[0] = item1;
                }

                
            }

            if (playerClass.ToUpper() == "WARRIOR")
            {
                Console.WriteLine("Item Added:  'Rusty Metal Sword' ");
                ob.inventory[0] = "Rusty Metal Sword";
            }

            if (playerClass.ToUpper() == "ROGUE")
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






    }
}

