using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Enemy : IActor
    {
        public Enemy(int hp, int damage, string name)
        {
            this.hp = hp;
            this.damage = damage;
            this.name = name;
        }

        public int hp { get ; set ; }
        public int damage { get ; set ; }
        public string name { get ; set ; }
    }
}
