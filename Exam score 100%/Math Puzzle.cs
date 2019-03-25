using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        if ((i+j+k==key) && (i<j && j<k))
                        {
                            counter++;
                            Console.WriteLine($"{i} + {j} + {k} = {key}");
                            
                        }
                        else if ((i*j*k==key) && (i>j && j>k))
                        {
                            counter++;
                            Console.WriteLine($"{i} * {j} * {k} = {key}");
                            
                        }


                    }
                }
            }
            if (counter==0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
