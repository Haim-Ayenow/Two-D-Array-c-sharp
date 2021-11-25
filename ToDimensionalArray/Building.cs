using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    public class Building
    {
        public int floor;
        public int apartment;
   
    public Building(int floor,int apartment)
    {
        this.floor = floor;
            this.apartment = apartment;

    }
        public void Build()
        {
            int[,] Building=new int[this.floor,this.apartment];

            Random random = new Random();
            for(int i = 0; i < Building.GetLength(0); i++)
            {
                for(int j = 0; j < Building.GetLength(1); i++)
                {
                    Building[i, j] = random.Next(10);

                    Console.WriteLine($"[{Building[i, j]}]");
                }
                Console.WriteLine();
            };
        }
    }
}
 