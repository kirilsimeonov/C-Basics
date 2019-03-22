using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string item = string.Empty;
           
            double sum = 0;

            while (budget>=0)
            {
                item = Console.ReadLine();
                if (item=="Stop")
                {
                    Console.WriteLine($"Money left: {budget}");
                    return;
                }

                for (int i = 0; i < item.Length; i++)
                {
                    int a = item[i];
                    sum += a;
                }
                if (budget>=sum)
                {
                    Console.WriteLine("Item successfully purchased!");
                }           
               
                budget -= sum;
                sum = 0;
            }
            Console.WriteLine("Not enough money!");

        }
    }
}
