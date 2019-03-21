using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int d = 1; d <= 9; d++)
                    {
                        for (int c = 1; c <= 9; c++)
                        {
                            if (n%i==0 && n%j==0 && n%d==0 && n%c==0)
                            {
                                Console.Write($"{i}{j}{d}{c} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
