using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;

            for (int i =1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    if (current>n)
                    {
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                
                Console.WriteLine();
                if (current > n)
                {
                    break;
                }
            }
        }
    }
}
