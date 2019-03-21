using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scribble
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumNon = 0;
            int sumPrime = 0;
            bool prime = true;

            while (command != "stop")
            {
                int num = int.Parse(command);

                if (num >= 0)
                {
                    if ((num <= 1) || ((num > 2) && (num % 2 == 0)) || ((num > 5) && num % 3 == 0))
                    {
                        sumNon += num;
                        prime = false;
                    }
                    if (prime == true)
                    {
                        for (int i = 2; i <= Math.Sqrt(num); i++)
                        {
                            if (num % i == 0)
                            {
                                sumNon += num;
                                prime = false;
                            }
                        }
                    }
                    if (prime == true)
                    {
                        sumPrime += num;
                    }

                }
                else
                {
                    Console.WriteLine("Number is negative.");
                }
                command = Console.ReadLine();
                prime = true;

            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNon}");
        }
    }
}
