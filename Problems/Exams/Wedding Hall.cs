using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());

            double hall = l * w;
            double bar = side * side;
            double dancing = 0.19 * hall;
            double freeSpace = hall - bar - dancing;
            double guests = freeSpace / 3.2;

            Console.WriteLine($"{Math.Ceiling(guests)}");

        }
    }
}
