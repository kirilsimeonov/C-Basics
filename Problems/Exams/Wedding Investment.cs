using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Invesment
{
    class Program
    {
        static void Main(string[] args)
        {
            string length = Console.ReadLine();
            string type = Console.ReadLine();
            string desert = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double price = 0;

            if (length =="one")
            {
                if (type=="Small")
                {
                    price = 9.98;
                }
                if (type == "Middle")
                {
                    price = 18.99;
                }
                if (type == "Large")
                {
                    price = 25.98;
                }
                if (type == "ExtraLarge")
                {
                    price = 35.99;
                }


            }
            else if (length =="two")
            {
                if (type == "Small")
                {
                    price = 8.58;
                }
                if (type == "Middle")
                {
                    price = 17.09;
                }
                if (type == "Large")
                {
                    price = 23.59;
                }
                if (type == "ExtraLarge")
                {
                    price = 31.79;
                } 
            }

            if (desert=="yes")
            {
                if (price <= 10)
                {
                    price += 5.5;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {    price += 3.85;
                }
            }
            if (length=="two")
            {
                price *= .9625;
            }

            Console.WriteLine($"{price*months:f2} lv.");

        }
    }
}
