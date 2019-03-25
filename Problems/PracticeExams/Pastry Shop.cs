using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_22Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            string cake = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            double price = 0;

            if (cake=="Cake")
            {
                if (day <= 15)
                {
                    price = 24 * 0.9 ;
                }
                else
                {
                    price = 28.7;
                }
            }
            if (cake=="Souffle")
            {
                if (day <= 15)
                {
                    price = 6.66*0.9;
                }
                else
                {
                    price = 9.8;
                }
            }
            if (cake=="Baklava")
            {
                if (day <= 15)
                {
                    price = 12.6*0.9;
                }
                else
                {
                    price = 16.98;
                }
            }
            double total = price * num;
            if (day<=22)
            {
                if (total >=100 && total<=200)
                {
                    total *= 0.85;
                }
                else if (total>200)
                {
                    total *= 0.75;
                }
            }
            Console.WriteLine($"{total:f2}");


        }
    }
}
