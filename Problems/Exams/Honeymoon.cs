using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double nightCost = 0;
            double ticket = 0;
            double totalCost = (2 * nightCost*nights) + ticket;
            if (city=="Cairo")
            {
                nightCost = 250;
                ticket = 600;
                totalCost = (2 * nightCost * nights) + ticket;
                if (nights<=4)
                {
                    totalCost *= 0.97;
                }
                if (nights>4 && nights<=9)
                {
                    totalCost *= 0.95;
                }
                if (nights > 9 && nights <= 24)
                {
                    totalCost *= 0.90;
                }
                if (nights > 24 && nights <= 49)
                {
                    totalCost *= 0.83;
                }
                if (nights>=50)
                {
                    totalCost *= 0.7;
                }

            }
            if (city == "Paris")
            {
                nightCost = 150;
                ticket = 350;
                totalCost = (2 * nightCost * nights) + ticket;
                if (nights > 4 && nights <= 9)
                {
                    totalCost *= 0.93;
                }
                if (nights > 9 && nights <= 24)
                {
                    totalCost *= 0.88;
                }
                if (nights > 24 && nights <= 49)
                {
                    totalCost *= 0.78;
                }
                if (nights >= 50)
                {
                    totalCost *= 0.7;
                }
            }
            if (city == "Lima")
            {
                nightCost = 400;
                ticket = 850;
                totalCost = (2 * nightCost * nights) + ticket;
                if (nights>24 && nights<=49)
                {
                    totalCost *= 0.81;
                }
                if (nights >= 50)
                {
                    totalCost *= 0.7;
                }
            }
            if (city == "New York")
            {
                nightCost = 300;
                ticket = 650;
                totalCost = (2 * nightCost * nights) + ticket;

                if (nights<=4)
                {
                    totalCost *= 0.97;
                }
                if (nights > 4 && nights <= 9)
                {
                    totalCost *= 0.95;
                }
                if (nights > 9 && nights <= 24)
                {
                    totalCost *= 0.88;
                }
                if (nights > 24 && nights <= 49)
                {
                    totalCost *= 0.81;
                }
                if (nights >= 50)
                {
                    totalCost *= 0.7;
                }
            }
            if (city == "Tokyo")
            {
                nightCost = 350;
                ticket = 700;
                totalCost = (2 * nightCost * nights) + ticket;
                if (nights > 9 && nights <= 24)
                {
                    totalCost *= 0.88;
                }
                if (nights > 24 && nights <= 49)
                {
                    totalCost *= 0.83;
                }
                if (nights >= 50)
                {
                    totalCost *= 0.7;
                }
            }
            
            if (budget>=totalCost)
            {
                Console.WriteLine($"Yes! You have {budget-totalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost-budget:f2} leva.");
            }
        }
    }
}
