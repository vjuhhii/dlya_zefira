using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            new Game().startGame();
            List<int> L = new List<int>();
           L.Add(3); 
           L.Add(5);
           L.Add(7);
           if (L.Contains(3)) Console.WriteLine("Есть");

        }
    }
}