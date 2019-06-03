using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    public class Blank 
    {
        protected float health;
        protected int damage;
        protected string name;
        protected Item weapon;
        protected Item[] inventory = new Item[10];
        protected int xp;
        protected int level;

        public Blank()
        {
            level = 0;
            xp = 0;
            name = "Default";


        }
    }
}
//this is a test.
// second test
