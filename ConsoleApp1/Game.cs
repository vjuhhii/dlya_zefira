using System;
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
        
        public enum Commands
        {
            test,
            test2,
            test3,
            test4,
            test5,
            test6,
        }
        
        delegate void Equip();
        Equip equipment;
        
        Person person = new Person("Илья", 100, 10);
        Enemy enemy = new Enemy(50, 15, "Серёжа", true);

        public List<Item> inv = new List<Item>(new[] { 
            new Potion(10, "Зелье лечения", Items.HealingPotion) 
        });
        

        public void startGame()
        {
            inv.Add(new Weapon(10, "Железный меч", Items.IronSword));
            
            while (true)
            {
                Commands command = (Commands)Enum.Parse(typeof(Commands),
                                      Console.ReadLine());

                switch (command)
                {
                    case Commands.test:
                        foreach(Item o in inv)
                        {
                            if (o.Type.Equals(Items.HealingPotion))
                            {
                                Console.WriteLine("ладыва");
                                continue;
                            }
                        }
                        break;
                    case Commands.test2:
                        Console.WriteLine(person.hp);
                        break;
                    case Commands.test3:
                        foreach (Item o in inv)
                        {
                            Console.WriteLine(o.mName);
                        }
                        break;
                    case Commands.test4:
                        Console.WriteLine(person.hp + "\n" + person.damage);
                        break;
                        case Commands.test5:

                        foreach (Item item in inv)
                        {
                            if (item.Type == Items.IronSword)
                            {
                                person.addWeaponRightHand(item)
                                Console.WriteLine(person.getDamage);
                                
                                continue;
                            }
                        }
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