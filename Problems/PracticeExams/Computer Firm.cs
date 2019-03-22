using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int comps = int.Parse(Console.ReadLine());
            int num = 0;
            int rating = 0;
            double sales = 0;
            double sumRating = 0;
            double avgRating = 0;
            double total = 0;

            for (int i = 1; i <= comps; i++)
            {
                num = int.Parse(Console.ReadLine());
                rating = num % 10;
                sumRating += rating;
                sales = (num-(num%10)) / 10;
                if (rating==2)
                {
                    sales *= 0;
                }
                if (rating==3)
                {
                    sales *=  0.5;
                }
                if (rating==4)
                {
                    sales *= 0.7;
                }
                if (rating==5)
                {
                    sales *= 0.85;
                }
                if (rating==6)
                {
                    sales *= 1;
                }
                total += sales;

            }
            
            avgRating = sumRating / comps;
            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"{avgRating:f2}");

        }
    }
}
