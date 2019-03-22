using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exam_25_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double souvenir = double.Parse(Console.ReadLine());
            double hotel = double.Parse(Console.ReadLine());

            double moneyTravel = 29.4 * 1.85;
         
            double moneyHotel = hotel * 0.9 + hotel*0.85 +hotel*0.8;
           
            double moneyFood = food * 3;
           
            double moneySouvenir = souvenir * 3;
           
            double totalSum = moneyFood + moneyHotel + moneySouvenir + moneyTravel;

            Console.WriteLine($"Money needed: {totalSum:f2}");
        }
    }
}
