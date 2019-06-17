using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    public abstract class Blank 
    {
        protected float health;
        protected int strength;
        protected string name;
        protected Item weapon;
        protected Item[] inventory = new Item[10];
        protected int xp;
        protected int level;
        protected int defense;
        protected int speed;
        protected int mp;


        public Blank()
        {
            level = 0;
            xp = 0;
            name = "Default";


        }
        public Item DropEquipment()
        {
            Item temp = weapon;
            return temp;

        }
        public abstract int attack();
    }
}