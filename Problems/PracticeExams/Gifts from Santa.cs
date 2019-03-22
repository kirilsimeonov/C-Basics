using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Gift_from_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int i = M; i >= N; i--)
            {
                if (i==S && i%2==0 && i%3==0)
                {
                    return;
                }
                if (i%2==0 && i%3==0)
                {
                    Console.Write($"{i} ");
                }

            }
        }
    }
}
