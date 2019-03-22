using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substitute2
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
            for (int i = K; i <= 8; i++)
            {
                for (int b = 9; b >= L; b--)
                {
                    for (int c = M; c <= 8; c++)
                    {
                        for (int d = 9; d >= N; d--)
                        {
                            if (i%2==0 && c%2==0 && b%2!=0 && d%2!=0)
                            {
                                if (counter < 6)
                                {


                                    if (i == c && b == d)
                                    {
                                        Console.WriteLine("Cannot change the same player.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{i}{b} - {c}{d}");
                                        counter++;
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
