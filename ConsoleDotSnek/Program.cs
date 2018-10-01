using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDotSnek
{
    class Program
    {

        

        static void Main(string[] args)
        {

            bool isGamePlaying = true;

            Console.WriteLine("I'm just a poor console, nobody reads me");

            Map gameMap = new Map();
            gameMap.printMap();

            Snake tempSnake = new Snake();


            while (isGamePlaying)
            {
                Console.Clear();

                tempSnake.updateLocation();
                gameMap.updateMap(tempSnake); //currently only does one snake
                gameMap.printMap();



                Console.ReadLine();

            }

                


        }
    }
}
