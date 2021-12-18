using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5; int height = 5;
            int[,] tab = new int[width, height];
            Filler.Fill(width, height, tab);

            for (int i=0; i<height; i++)
            {
                Draw.Row(i, width, tab);
                Console.Write(" # \t" + Count.Row(i, width, tab));
                Console.WriteLine();
            }
            Draw.Rowofhash(width);
            Draw.EndRow(height, width-1, tab);
            Console.ReadKey();
        }
    }
}
