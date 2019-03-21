using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());
            string name = string.Empty;
            double weight = 0;
            double letterSum = 0;
            double price = 0;
            double totalSum = 0;
            int counter = 0;
            for (int i = 1; i <= quota; i++)
            {
                name = Console.ReadLine();
                if (name=="Stop")
                {
                    break;
                }
                weight = double.Parse(Console.ReadLine());

                if (i % 3 != 0)
                {
                    for (int d = 0; d < name.Length; d++)
                    {
                        int letter = (int)name[d];
                        letterSum += letter;
                    }
                    price = letterSum / weight;
                    totalSum -= price;
                    letterSum = 0;
                    price = 0;
                }
                else
                {
                    for (int d = 0; d < name.Length; d++)
                    {
                        int letter = (int)name[d];
                        letterSum += letter;
                    }
                    price = letterSum / weight;
                    totalSum += price;
                    letterSum = 0;
                    price = 0;
                }
                counter++;
            }
            if (counter==quota)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
                if (totalSum>=0)
                {
                    Console.WriteLine($"Lyubo's profit from {quota} fishes is {totalSum:f2} leva.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Lyubo lost {Math.Abs(totalSum):f2} leva today.");
                    return;
                }
            }
            else if (counter<quota)
            {
                if (totalSum >= 0)
                {
                    Console.WriteLine($"Lyubo's profit from {counter} fishes is {totalSum:f2} leva.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Lyubo lost {Math.Abs(totalSum):f2} leva today.");
                    return;
                }
            }

             
        }
    }
}
