using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    public class Chocolate
    {
        public int row;
        public int line;


        public Chocolate(int row, int line)
        {
            this.row = row;
            this.line = line;
        }

        public void ChocolateBox()
        {
            int[,] ChocolateBox1 = new int[this.row, this.line];
            Random random= new Random();
            for(int i = 0; i < ChocolateBox1.GetLength(0); i++)
            {
                for(int j = 0; j < ChocolateBox1.GetLength(1); i++)
                {
                    ChocolateBox1[i, j] = random.Next(100);
                    Console.WriteLine($"[{ChocolateBox1[i, j]}]");
                }
                Console.WriteLine();
            }
        }
        public void ChocolateBox55()
{
            int[,] ChocolateBox1 = new int[this.row, this.line];
            Random random = new Random();
            for(int i=0;i<ChocolateBox1.GetLength(0); i++)
            {
                for( int j = 0; j < ChocolateBox1.GetLength(1); i++)
                {
                    ChocolateBox1[i, j] = random.Next(100);
                    if(ChocolateBox1[i,j] > 55)
                    {
                        Console.WriteLine($"[{ChocolateBox1[i, j]}]");
                    }
                    else
                    {
                        Console.WriteLine("milk");
                    }
                    Console.WriteLine();
                }
            }
}
    }
}


