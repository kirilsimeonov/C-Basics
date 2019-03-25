using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int points = 0;
            double sumPoints = 0;

            for (int i = 1; i <= parts; i++)
            {
                points = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    points *= 2;
                }
                sumPoints += points;
            }
            double prize = sumPoints * money;
            Console.WriteLine($"The project prize was {prize:f2} lv.");
        }
    }
}
