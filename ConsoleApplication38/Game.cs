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
            //INTRO
            Console.WriteLine("Welcome to Dungeon Divers! A strategic turn based game that explores through a vast dungeon with doors to open and rooms to explore. Be advised monsters exist within the game and it's your job to take care of those monsters by any means necessary to level up and become stronger. Your goal is to collect items, by fighting, level up and /*get out the dungeon/*");
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
                ob.inventory[0] = 

            }


    }






}
}

