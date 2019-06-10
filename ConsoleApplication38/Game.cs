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
            obj.Intro();

            obj.TrainingLevel();


            Console.ReadKey();
        }

        void Menu()
        {
            Console.WriteLine("___  _  _ _  _ ____ ____ ____ _  _    ___  _ _  _ ____ ____ ____ ");
            Console.WriteLine("|  \\ |  | |\\ | | __ |___ |  | |\\ |    |  \\ | |  | |___ |__/ [__  ");
            Console.WriteLine("|__/ |__| | \\| |__] |___ |__| | \\|    |__/ |  \\/  |___ |  \\ ___] ");

        }


        string Intro()
        {

            Console.WriteLine("Welcome to Dungeon Divers! A strategic turn based game that explores through a vast dungeon with doors to open and roomsto explore. Be advised monsters exist within the game and it's your job to take care of those monsters by any means");
            Console.WriteLine("necessary to level up and become stronger.Your goal is to collect items, by fighting, level up and");
            




            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();
            return userName;
        }


        void TrainingLevel() //Introductory Level
        {
            Rogue rog = new Rogue();
            Item ob = new Item();

            string placeHolderForThePlayer = "NULL"; //PlaceHolder
            string playerClass = "WARRIOR";  //PlaceHolder


            Console.WriteLine("Welcome " + placeHolderForThePlayer + " I will be your teacher, Chiron.  My job here is to make sure you are ready to begin your Great Adventure.");
            Console.WriteLine("Firstly, every hero needs a weapon.  I will gift you a weapon now to start your adventure.");
            //using a placeholder for the player class.  Chiron is going to give them a weapon depending on which class they use.

            if ( playerClass == "MAGE")
            {
                int i = 0;

                Console.WriteLine("Item Added: 'Weak Wooden Staff' ");
                ob.inventory[0] = "Weak Wooden Staff";
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






    }
}

