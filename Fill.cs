using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Filler
    {
        public static void Fill(int width, int height, int[,] tab)
        {
            Random rnd = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    tab[i, j] = rnd.Next(1, 10);
                }
            }
        }
    }
}
