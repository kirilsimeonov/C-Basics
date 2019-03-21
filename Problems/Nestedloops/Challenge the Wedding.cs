using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int counter = 0;
            
            


                for (int j = 1; j <= men; j++)
                {
                    for (int d = 1; d <= women; d++)
                    {
                        counter++;
                    if(counter>tables)
                    {
                        break;
                    }
                    Console.Write($"({j} <-> {d}) ");
                }
                }
            
        }
    }
}
