using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double time = distance * timePerMeter;
            double additionalTime = (Math.Floor(distance / 50)) * 30;
            double totalTime = time + additionalTime;

            if (totalTime>=record)
            {
                Console.WriteLine($"No! He was {totalTime-record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
        }
    }
}
