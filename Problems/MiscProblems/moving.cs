using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int total = width * length * height;
            string command = string.Empty;
            int sum = 0;
            int box = 0;

            while (sum<total)
            {
                command = Console.ReadLine();

                if (command == "Done")
                {
                    Console.WriteLine($"{total - sum} Cubic meters left.");
                    break;
                }
                else
                {
                    
                    //box = Convert.ToInt32(command);
                    box = int.Parse(command);
                    
                    sum += box;
                    if (sum > total)
                    {
                        Console.WriteLine($"No more free space! You need {sum - total} Cubic meters more.");
                    }
                }
            }

        }
    }
}
