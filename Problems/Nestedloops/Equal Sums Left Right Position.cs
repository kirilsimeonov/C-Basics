using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                int s1 = i % 10;
                int s2 = (i / 10) % 10;
                int s3 = (i / 100) % 10;
                int s4 = (i / 1000) % 10;
                int s5 = (i / 10000) % 10;
                int sum1 = s1 + s2;
                int sum2 = s4 + s5;

                if (sum1==sum2)
                {
                    Console.Write(i+" ");
                }
                else if (s3==Math.Abs(sum1-sum2))
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
