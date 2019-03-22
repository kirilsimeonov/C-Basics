using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double price = 0;
            double total = 0;

            if (month == "march" || month=="april" || month =="may")
            {
                if (day=="day")
                {
                    price = 10.5;
                }
                if (day=="night")
                {
                    price = 8.4;
                }
            }

            if (month == "june" || month == "july" || month == "august")
            {
                if (day == "day")
                {
                    price = 12.6;
                }
                if (day == "night")
                {
                    price = 10.2;
                }
            }

            if (hours >= 5)
            {
                price *= 0.5;
            }
            if (num >= 4)
            {
                price *= 0.9;
            }
           
            total = num * hours * price;

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {total:f2}");
        }
    }
}
