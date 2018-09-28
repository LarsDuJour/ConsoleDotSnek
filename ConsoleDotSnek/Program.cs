using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotSnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm just a poor console, nobody reads me");

            Map gameMap = new Map();
            gameMap.printMap();
        }
    }
}
