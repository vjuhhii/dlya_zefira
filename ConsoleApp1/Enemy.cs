using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Enemy : IActor
    {
        bool active; 
        public Enemy(int hp, int damage, string name, bool active)
        {
            this.hp = hp;
            this.damage = damage;
            this.name = name;
            this.active = active;
        }

        public int hp { get ; set ; }
        public int damage { get ; set ; }
        public string name { get ; set ; }
    }
}
