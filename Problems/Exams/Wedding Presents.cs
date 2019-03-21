using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            double presents = double.Parse(Console.ReadLine());
            string category = "";
            int money = 0;
            int electric = 0;
            int voucher = 0;
            int others = 0;
            for (int i = 1; i <= presents; i++)
            {
                category = Console.ReadLine();
                if (category == "A")
                {
                    money++;
                }
                if (category == "B")
                {
                    electric++;
                }
                if (category == "V")
                {
                    voucher++;
                }
                if (category == "G")
                {
                    others++;
                }

            }
            Console.WriteLine($"{((money / presents) * 100):f2}%");
            Console.WriteLine($"{((electric / presents) * 100):f2}%");
            Console.WriteLine($"{((voucher / presents) * 100):f2}%");
            Console.WriteLine($"{((others / presents) * 100):f2}%");
            Console.WriteLine($"{((presents / guests) * 100):f2}%");

        }
    }
}
