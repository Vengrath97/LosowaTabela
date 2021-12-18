using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Draw
    {
        public static void Row(int cHeight, int width, int[,] tab)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write(tab[cHeight, i] + "\t");
            }
        }
        public static void EndRow(int height, int cWidth, int[,] tab)
        {
            for (int i = 0; i < height; i++)
            {
                Console.Write(Count.Column(i, height, tab) + "\t");
            }

        }
        public static void Rowofhash(int width)
        {
            for (int i = 0; i < width+1; i++)
            {
                Console.Write(" # \t");
            }
            Console.WriteLine();
        }
    }
}
