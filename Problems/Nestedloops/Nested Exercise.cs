using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());


            for (int firstFirst = a; firstFirst <= b; firstFirst++)
            {
                for (int firstSecond = a; firstSecond <=b; firstSecond++)
                {
                    for (int secondFirst = c; secondFirst <= d; secondFirst++)
                    {
                        for (int secondSecond = c; secondSecond <= d; secondSecond++)
                        {
                            if ((firstFirst+secondSecond) == (firstSecond+secondFirst) &&
                                    (firstFirst!=firstSecond) &&
                                    (secondFirst!=secondSecond))
                            {
                                Console.WriteLine($"{firstFirst}{firstSecond}");
                                Console.WriteLine($"{secondFirst}{secondSecond}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }


        }
    }
}
