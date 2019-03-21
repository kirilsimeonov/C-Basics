using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int d = 1; d <= 9; d++)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            for (int s = 1; s <= 9; s++)
                            {
                                for (int g = 1; g <= 9; g++)
                                {
                                    if (i*j*d*k*s*g == n)
                                    {
                                        Console.Write($"{i}{j}{d}{k}{s}{g} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
