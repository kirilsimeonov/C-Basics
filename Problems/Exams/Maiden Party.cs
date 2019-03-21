using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double party = double.Parse(Console.ReadLine());
            double message = double.Parse(Console.ReadLine());
            double roses = double.Parse(Console.ReadLine());
            double keyholders = double.Parse(Console.ReadLine());
            double caricatures = double.Parse(Console.ReadLine());
            double lucks = double.Parse(Console.ReadLine());

            double number = message + roses + keyholders + caricatures + lucks;

            double totalSum = message * 0.6 + roses * 7.2 + keyholders * 3.6 + caricatures * 18.2 + lucks * 22;
            

            if (number>=25)
            {
                totalSum *= 0.65;
            }
            double finalSum = 0.9 * totalSum;

            if (finalSum>=party)
            {
                Console.WriteLine($"Yes! {(finalSum-party):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {party-finalSum:f2} lv needed.");
            }

        }
    }
}
