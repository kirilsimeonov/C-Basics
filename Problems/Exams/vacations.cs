using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            string action = string.Empty;
            double moneyInput = 0;
            int days = 0;
            int spend = 0;

            while (true)
            {
                action = Console.ReadLine();
                moneyInput = double.Parse(Console.ReadLine());

                if (action=="spend")
                {
                    moneyAvailable -= moneyInput;
                    if (moneyAvailable < 0)
                    {
                        moneyAvailable = 0;
                        
                    }
                    days++;
                    spend++;
                }
                if (action=="save")
                {
                    moneyAvailable += moneyInput;
                    spend = 0;
                    days++;
                }
                if (spend==5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    return;
                }
                if (moneyAvailable>=moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }

            }

        }
    }
}
