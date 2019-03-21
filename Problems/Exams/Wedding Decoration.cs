using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int flowers = 0;
            int balloons = 0;
            int candles = 0;
            int ribbon = 0;
            double price = 0;
            
            double sum = 0;

            string command = Console.ReadLine();

            while (command!="stop")
            {
                
                int num = int.Parse(Console.ReadLine());
                if (command=="flowers")
                {
                    price = 1.5 * num;
                    flowers += num;;
                }
                if (command == "balloons")
                {
                    price = 0.1 * num;
                    balloons+=num;
                }
                if (command == "candles")
                {
                    price = 0.5 * num;
                    candles+=num;
                }
                if (command == "ribbon")
                {
                    price = 2 * num;
                    ribbon += num; 
                }
                sum += price;
                if (sum>=budget)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (sum>=budget)
            {
                Console.WriteLine("All money is spent!");
            }
            else if (budget>sum)
            {
                Console.WriteLine($"Spend money: {sum:f2}");
                Console.WriteLine($"Money left: {budget-sum:f2} ");
            }
            Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
        }
    }
}
