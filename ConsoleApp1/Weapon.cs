using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Weapon : Item
    {
        public int damage;
        public bool equip;

        public Weapon(int damage, bool equip, string name, Game.Items type)
        {
            this.damage = damage;
            this.equip = equip;
            this.mName = name;
            this.Type = (int)type;
        }

        public string mName { get ; set ; }
        public int Type { get ; set ; }
    }
}
