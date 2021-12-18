using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Count
    {
        public static int Row(int cHeight, int width, int[,] tab)
        {
            int tempsuma = 0;
            for (int i = 0; i < width; i++)
            {
                tempsuma += tab[cHeight, i];
            }
            return tempsuma;
        }
        public static int Column(int col, int height, int[,] tab)
        {
            int tempsuma = 0;
            for (int i = 0; i < height; i++)
            {
                tempsuma += tab[i, col];
            }
            return tempsuma;
        }
    }
}
