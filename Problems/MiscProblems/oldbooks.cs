using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            string input = "";

            while (input!=book || counter<number)
            {
                input = Console.ReadLine();
                counter++;

                if (input == book)
                {
                    Console.WriteLine($"You checked {counter-1} books and found it.");
                    return;
                }
                else if (counter == number)
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($" You checked {counter} books.");
                    return;
                }
            }
            
        }
    }
}
