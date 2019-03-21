
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scribble
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <= (char)99; i++)
            {
                Console.WriteLine(i);
            }
            char B = char.Parse(Console.ReadLine());

            for (char d = 'A'; d <= B; d++)
            {
                Console.WriteLine(d);
            }
        }
    }
}
