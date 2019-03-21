using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = 'B'; i <= 'L'; i++)
            {
                for (char j = 'f'; j >= 'a'; j--)
                {
                    for (char a = 'A'; a <= 'C'; a++)
                    {
                        for (int k = 1; k <= 10; k++)
                        {
                            for (int g = 10; g >= 1; g--)
                            {

                                if (i%2==0)
                                {
                                    counter++;
                                    
                                }
                                if (counter==number)
                                {
                                    Console.WriteLine($"Ticket combination: {i}{j}{a}{k}{g}");
                                    Console.WriteLine($"Prize: {i+j+a+k+g} lv.");
                                    return;

                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
