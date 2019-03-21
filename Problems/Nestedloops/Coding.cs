using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            //2049->9

            double b = n.ToString().Length;

            for (int i = 1; i <= b; i++) //redove
            {
                double last = n % 10;
                if (last != 0)
                {

                    for (int k = 1; k <= last; k++)
                    {
                        double lastPlus = last + 33;

                        Console.Write((char)lastPlus);
                    }
                    
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("ZERO");
                }
                n = (n - last) / 10;
                last = n % 10;

            }
        }
    }
}
