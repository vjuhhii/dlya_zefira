﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
   
   public class Game
    {
        public enum Items
        {
            IronSword,
            HealingPotion,
        }
        
        public enum commands
        {
            test,
            test2,
            test3,
            test4,
            test5,
            test6,
        }

        int a = 1;
        Person person = new Person("Илья", 100, 10);
        Enemy enemy = new Enemy(50, 15, "Серёжа");

        public List<Item> inv = new List<Item>(new[] { 
            new Potion(10, "Зелье лечения", Items.HealingPotion) 
        });


        public void startGame()
        {
            inv.Add(new Weapon(10, false, "Железный меч", Items.IronSword));
            commands a = (commands)Enum.Parse(typeof(commands),
                                  Console.ReadLine());
            
            while (true)
            {

                //   List<item> inv = new List<item>();

                
                switch (a)
                {
                   
                    case commands.test:
                        //addItem(new Potion(10, "Зелье лечения"));
                        foreach(Item o in inv)
                        {
                            if (o.mName.Equals("Зелье лечения"))
                            {
                                Console.WriteLine("ладыва");
                                continue;
                            }
                        }
                       // if (inv.Contains(new Potion(10, "Зелье лечения"))) Console.WriteLine("да)
                        break;
                     

                    case commands.test2:
                        Console.WriteLine(person.hp);
                        break;
                    case commands.test3:
                        foreach (Item o in inv)
                        {
                            Console.WriteLine(o.mName);
                        }
                        break;
                    case commands.test4:
                        Console.WriteLine(person.hp + "\n" + person.damage);
                        break;
                        case commands.test5:

                          Console.WriteLine(inv[Convert.ToInt32(a)]);
                        break;
                }

            }
        }
         public void addItem(Item item)
        {
            inv.Add(item);
            Console.WriteLine("Добавился новый предмет");
        }
         public void removeItem(Item item)
        {
            inv.Remove(item);
        }

    }
}
    

