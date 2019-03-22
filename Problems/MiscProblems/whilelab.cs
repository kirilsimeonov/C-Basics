using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLab
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int result = 0;
            if (n2==0)
            {
                result = n1;
            }
            else
            {
                while (n2!=0)
                {
                    result = n2;
                    n2 = n1 % n2;
                    n1 = result;
                }
            }
            Console.WriteLine(result);
        }
    }
}
