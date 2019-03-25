using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int sumFood = 0;
            while (command!="Adopted")
            {
                command = Console.ReadLine();
                if (command == "Adopted")
                {
                    if (food * 1000 >= sumFood)
                    {
                        Console.WriteLine($"Food is enough! Leftovers: {(food * 1000) - sumFood} grams.");
                    }
                    else if (food * 1000 < sumFood)
                    {
                        Console.WriteLine($"Food is not enough. You need {sumFood - (food * 1000)} grams more.");
                    }
                    return;
                }
                int daily = int.Parse(command);
                sumFood += daily;

                
                
            }

        }
    }
}
