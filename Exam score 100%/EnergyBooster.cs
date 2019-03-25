using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribble
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());
            double price = 0;

            if (fruit=="Watermelon")
            {
                if (size=="small")
                {
                    price = 2 * 56;
                }
                if (size=="big")
                {
                    price = 5 * 28.70;
                }

            }
            if (fruit == "Mango")
            {
                if (size == "small")
                {
                    price = 2 * 36.66;
                }
                if (size == "big")
                {
                    price = 5 * 19.60;
                }

            }
            if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = 2 * 42.10;
                }
                if (size == "big")
                {
                    price = 5 * 24.80;
                }

            }
            if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    price = 2 * 20;
                }
                if (size == "big")
                {
                    price = 5 * 15.20;
                }

            }
            double totalPrice = price * sets;
            if (totalPrice>=400 && totalPrice<=1000)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 1000)
            {
                totalPrice *= 0.5;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
            

        }
    }
}
