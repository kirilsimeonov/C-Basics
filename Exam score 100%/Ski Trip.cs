using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int stay = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string positive = Console.ReadLine();
            double price = 0;

            if (room == "room for one person")
            {
                price = 18;
            }
            if (room=="apartment")
            {
                if (stay<10)
                {
                    price = 25 * 0.7;
                }
                if (stay>=10 && stay<=15)
                {
                    price = 25 * 0.65;
                }
                if (stay>15)
                {
                    price = 25 * 0.5;
                }
            }
            if (room == "president apartment")
            {
                if (stay < 10)
                {
                    price = 35 * 0.9;
                }
                if (stay >= 10 && stay <= 15)
                {
                    price = 35 * 0.85;
                }
                if (stay > 15)
                {
                    price = 35 * 0.8;
                }
            }
            double totalPrice = price * (stay - 1);
            if (positive=="positive")
            {
                totalPrice *= 1.25;
            }
            if (positive=="negative")
            {
                totalPrice *= 0.9;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
