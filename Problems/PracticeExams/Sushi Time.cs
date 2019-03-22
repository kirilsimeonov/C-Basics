using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string YorN = Console.ReadLine();
            double price = 0;


            if (restaurant != "Sushi Zone" && restaurant != "Sushi Time" && restaurant != "Sushi Bar" && restaurant != "Asian Pub")
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
                return;
            }

            if (restaurant == "Sushi Zone" || restaurant == "Sushi Time" || restaurant == "Sushi Bar" || restaurant == "Asian Pub")
            {
                if (restaurant == "Sushi Zone")
                {
                    if (sushi == "sashimi") { price = 4.99; }
                    if (sushi == "maki") { price = 5.29; }
                    if (sushi == "uramaki") { price = 5.99; }
                    if (sushi == "temaki") { price = 4.29; }
                }
                if (restaurant == "Sushi Time")
                {
                    if (sushi == "sashimi") { price = 5.49; }
                    if (sushi == "maki") { price = 4.69; }
                    if (sushi == "uramaki") { price = 4.49; }
                    if (sushi == "temaki") { price = 5.19; }
                }
                if (restaurant == "Sushi Bar")
                {
                    if (sushi == "sashimi") { price = 5.25; }
                    if (sushi == "maki") { price = 5.55; }
                    if (sushi == "uramaki") { price = 6.25; }
                    if (sushi == "temaki") { price = 4.75; }
                }
                if (restaurant == "Asian Pub")
                {
                    if (sushi == "sashimi") { price = 4.50; }
                    if (sushi == "maki") { price = 4.80; }
                    if (sushi == "uramaki") { price = 5.50; }
                    if (sushi == "temaki") { price = 5.50; }
                }
            }
            double totalSum = price * number;
            if (YorN == "Y")
            {
                totalSum *= 1.2;
            }
            Console.WriteLine($"Total price: {Math.Ceiling(totalSum)} lv.");
        }
    }
}
