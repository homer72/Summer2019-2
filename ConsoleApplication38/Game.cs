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

            Game ob = new Game();

            ob.Intro();





            Console.ReadKey();
        }




        void Intro()
        {
            Console.WriteLine("Welcome to Dungeon Divers!");

        }


        void TrainingLevel() //Introductory Level
        {
            string placeHolderForThePlayer = "NULL"; //PlaceHolder
            string playerClass = "PlaceHolder";  //PlaceHolder


            Console.WriteLine("Welcome " + placeHolderForThePlayer + " I will be your teacher, Chiron.  My job here is to make sure you are ready to begin your Great Adventure.");
            Console.WriteLine("Firstly, every hero needs a weapon.  I will gift you a weapon now to start your adventure.");
            //using a placeholder for the player class.  Chiron is going to give them a weapon depending on which class they use.

            if ( playerClass == "MAGE")
            {
                Console.WriteLine("Item Added:  'Weak Wooden Staff' ");
                Item ob = new Item();
                ob.inventory[0] = "Weak Wooden Staff";

            }

            else if (playerClass == "WARRIOR")
            {
                Console.WriteLine("Item Added:  'Rusty Metal Sword' ");
                Item ob = new Item();
                ob.inventory[0] = "Rusty Metal Sword";
            }

            else if (playerClass == "ROGUE")
            {
                Console.WriteLine("Item Added:  'Rusty Metal Daggers' ");
                Item ob = new Item();
                ob.inventory[0] = "Rusty Metal Daggers";
            }

            
            
            

            

        }






    }
}

