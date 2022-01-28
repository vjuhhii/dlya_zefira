using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person : IActor
    {
        public Person(string name, int hp, int damage)
        {
            this.damage = damage;
            this.hp = hp;
            this.name = name;
        }

        public int hp { get ; set ; }
        public int damage { get ; set ; }
        public string name { get ; set ; }
    }
}
