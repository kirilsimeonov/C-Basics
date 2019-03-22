using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
            int on = 0;
            int off = 0;
            

            for (int i = 1; i <= stops; i++)
            {
                off = int.Parse(Console.ReadLine());
                on = int.Parse(Console.ReadLine());

                passengers = passengers - off + on;

                if (i%2!=0)
                {
                    passengers += 2;
                }
                else if (i%2==0)
                {
                    passengers -= 2;
                }


            }
            Console.WriteLine($"The final number of passengers is : {passengers}");
        }
    }
}
