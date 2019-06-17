using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    public abstract class Blank 
    {
        public float health;
        protected int strength;
        protected string name;
        protected Item weapon;
        public Item[] inventory = new Item[10];
        protected int xp;
        public int level;
        public int defense;
        public int speed;
        public int mp;


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
        public abstract void message();
        public abstract int attack();
    }
}