using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstRow = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = 'A'; i <= lastSector; i++)
            {
                
                for (int d = 1; d <= firstRow; d++)
                {

                    if (d % 2 != 0)
                    {
                        for (char j = 'a'; j <= (char)(96 + seats); j++)
                        {
                            counter++;
                            Console.WriteLine($"{i}{d}{j}");
                            
                        }
                    }
                    else
                    {
                        for (char j = 'a'; j <= (char)(98 + seats); j++)
                        {
                            counter++;
                            Console.WriteLine($"{i}{d}{j}");
                           
                        }
                    }

                    
                }
                firstRow++;
            }
            Console.WriteLine(counter);
        }
    }
}
