using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int d = 0; d <= n; d++)
                    {
                        for (int k = 0; k <= n; k++)
                        {
                            for (int z = 0; z <= n; z++)
                            {

                                if (z + k + d + j + i == n)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }

            }
            Console.WriteLine(counter);
        }
    }
}