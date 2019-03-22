using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());

            double volume = w * l * h;
            double room = (average + 0.4) * 2 * 2;
            double space = Math.Floor(volume / room);

            if (space >=3 && space <=10)
            {
                Console.WriteLine($"The spacecraft holds {space} astronauts.");
            }
            else if(space<3)
            {
                Console.WriteLine("The spacecraft is too small.");

            }
            else if (space>10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
