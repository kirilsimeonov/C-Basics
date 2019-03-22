using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDeposits = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0;
            double deposit = 0;


            while (counter < numberOfDeposits)
            {
                deposit = double.Parse(Console.ReadLine());
                if (deposit>0)
                {
                    sum += deposit;
                    Console.WriteLine($"Increase: {deposit:f2}");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:f2}");
                    return;

                }
            }
            Console.WriteLine($"Total: {sum:f2}");

        }
    }
}
