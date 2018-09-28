using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotSnek
{
    class Map
    {
        private char[,] map;
        private int mapWidth;
        private int mapHeight;

        public Map()
        {
            map = new char[10,10]
            {
                { 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x' },
                { 'x', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                { 'x', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                { 'x', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                { 'x', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                { 'x', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                { 'x', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                { 'x', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                { 'x', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                { 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x' }
            };

            mapHeight = 9;
            mapWidth = 9;


        }



        public void printMap()
        {
            for (int i = 0; i <= mapWidth; i++)
            {
                for (int j = 0; j <= mapHeight; j++)
                {
                 Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }


    }
}
