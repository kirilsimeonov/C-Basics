using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = string.Empty;
         
            double sum = 0;
            double input = 0;
            double budget = 0;
            while (place!="End")
            {
              
                place = Console.ReadLine();
                if (place == "End")
                {
                    return;
                }
                budget = double.Parse(Console.ReadLine());

                while (sum<budget)
                {
                    
                    input =double.Parse(Console.ReadLine());
                    sum += input;
                }
                Console.WriteLine($"Going to {place}!");
                sum = 0;
            }
            
        }
    }
}
