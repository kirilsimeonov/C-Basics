using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int adults = 0;
            int kids = 0;
            int toyMoney = 0;
            int sweatersMoney = 0;

            while (true)
            {
                command = Console.ReadLine();
                if (command=="Christmas")
                {
                    break;
                }
                double input = double.Parse(command);
                if (input<=16)
                {
                    kids++;
                    toyMoney += 5;
                }
                else
                {
                    adults++;
                    sweatersMoney += 15;
                }
            }
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {toyMoney}");
            Console.WriteLine($"Money for sweaters: {sweatersMoney}");
        }
    }
}
