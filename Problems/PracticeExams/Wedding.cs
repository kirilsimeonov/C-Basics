using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            
            int num = 0;
            double price = 0;
            int balloons = 0;
            int ribbon = 0;
            int flowers = 0;
            int candles = 0;
            double total = 0;
            string command = Console.ReadLine();
            while (command!="stop")
            {
                
                num = int.Parse(Console.ReadLine());
                if (command == "balloons")
                {
                    price = 0.1;
                    balloons += num;
                    total += num * price;
                }
                else if (command == "ribbon")
                {
                    price = 2;
                    ribbon += num;
                    total += num * price;
                }
                else if (command == "flowers")
                {
                    price = 1.5;
                    flowers += num;
                    total += num * price;
                }
                else if (command== "candles")
                {
                    price = 0.5;
                    candles += num;
                    total += num * price;
                }
                if (total>=budget)
                {
                    Console.WriteLine($"All money is spent!");
                    Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
                    return;
                }
               command = Console.ReadLine();
            }
            if (command=="stop")
            {
                Console.WriteLine($"Spend money: {total:f2}");
                Console.WriteLine($"Money left: {budget-total:f2}");
                Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
            }
        }
    }
}
