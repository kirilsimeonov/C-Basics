using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double sum = 0;
            string button = "";
            int counter = 0;

            while (sum < capacity)
            {
                button = Console.ReadLine();
                if (button == "Easy")
                {
                    sum += 50;
                    counter++;
                }
                if (button == "Medium")
                {
                    sum += 100;
                    counter++;
                }
                if (button == "Hard")
                {
                    sum += 200;
                    counter++;
                }
            }
            if (sum == capacity)
            {
                Console.WriteLine($"The dispenser has been tapped {counter} times.");
            }
            if (sum > capacity)
            {
                Console.WriteLine($"{sum-capacity}ml has been spilled.");
            }





        }
    }
}
