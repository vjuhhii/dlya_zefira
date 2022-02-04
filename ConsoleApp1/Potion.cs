using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Potion : Item
    {
        public int heal;
        public bool active;

        public Potion(int heal, string name, Game.Items type)
        {
            this.heal = heal;
            this.mName = name;
            this.Type = type;
        }

        public string mName { get; set; }
        public Game.Items Type { get ; set; }
    }
}
