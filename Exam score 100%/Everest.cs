using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseCamp = 5364;
            string command = Console.ReadLine();
            double step = 0;
            int counter = 1;
            if (command=="No")
            {
                counter = 0;
            }

            while (command!="END")
            {
                step = double.Parse(Console.ReadLine());
                if (counter == 5)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(baseCamp);
                    return;
                }
                baseCamp += step;
               
                if (baseCamp>=8848)
                {
                    Console.WriteLine($"Goal reached for {counter+1} days!");
                    return;
                }
               
                command = Console.ReadLine();
                if (command == "Yes")
                {
                    counter++;
                }
            }
            if (command=="END")
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(baseCamp);
                return;
            }
        }
    }
}
