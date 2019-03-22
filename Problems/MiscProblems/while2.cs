using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {
            int payment= int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            while (sum==200)
            {

                if (sum>=200)
                {
                    break;
                }
                sum = sum + payment;
                counter++;
                payment = int.Parse(Console.ReadLine());
                
            }
        }
    }
}
