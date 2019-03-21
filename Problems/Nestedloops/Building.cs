using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string prefix = string.Empty;

            for (int i = floors; i > 0; i--)
            {
                if (i == floors)
                {
                    prefix = "L";
                }
                else if (i % 2 == 0)
                {
                    prefix = "O";
                }
                else if (i % 2 != 0)
                {
                    prefix = "A";
                }

                for (int j = 0; j < rooms; j++)
                {
                    Console.Write($"{prefix}{i}{j} ");

                }
                Console.WriteLine();
            }
        }
    }
}
