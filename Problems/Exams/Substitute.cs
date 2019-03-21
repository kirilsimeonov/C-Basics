using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int k = K; k <= 8; k++)
            {
                for (int l = 9; l >=L; l--)
                {
                    for (int m = M; m <= 8; m++)
                    {
                        for (int n = 9; n >= N; n--)
                        {
                            if (k%2==0 && m%2==0 && l%2!=0 && n%2!=0)
                            {
                                if (k == m && l == n)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    counter++;
                                    Console.WriteLine($"{k}{l} - {m}{n}");
                                    
                                }

                                if (counter == 6) { return; };
                            }
                            

                        }
                    }
                }
            }
        }
    }
}
