using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  public class Weapon : Item
    {
        public int damage;
        public bool equip;

        public Weapon(int damage, string name, Game.Items type)
        {
            this.damage = damage;
            this.mName = name;
            this.Type = type;
        }

        public string mName { get ; set ; }
        public Game.Items Type { get ; set ; }
    }
}
