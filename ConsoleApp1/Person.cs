using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person : IActor
    {
        public int hp { get ; set ; }
        public int damage { get ; set ; }
        public string name { get ; set ; }

        public Item rightHand { get ; set ; }
        public Item leftHand { get ; set ; }

        public Person(string name, int hp, int damage)
        {
            this.damage = damage;
            this.hp = hp;
            this.name = name;
        }

        public void addWeaponRightHand(Item item) 
        {
            rightHand = type;
        }

        public void addWeaponLeftHand(Item item) 
        {
            leftHand = type;
        }

        public int getDamage()
        { 
            return rightHand + leftHand;
        }
    }
}
