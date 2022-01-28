using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IActor
    {
        int hp { get; set; }
        int damage { get; set; }
        string name { get; set; }        
    }
}
