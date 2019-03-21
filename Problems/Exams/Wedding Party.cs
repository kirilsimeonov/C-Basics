using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int price = 20;
            int totalGuests = guests * price;

            double fire = 0.4 * (budget-totalGuests);
            double donation = 0.6 * (budget - totalGuests);
            if (budget>=totalGuests)
            {
                Console.WriteLine($"Yes! {fire:f0} lv are for fireworks and {donation:f0} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {(totalGuests-budget):f0} lv more.");
            }
        }
    }
}
