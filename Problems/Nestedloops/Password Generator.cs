using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char d = 'a'; d <= (char)(96+L) ; d++)
                    {
                        for (char z = 'a'; z <= (char)(96+L); z++)
                        {
                            for (int a = 1; a <= n; a++)
                            {
                                if (a>i && a>j)
                                {
                                    Console.Write($"{i}{j}{d}{z}{a} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
