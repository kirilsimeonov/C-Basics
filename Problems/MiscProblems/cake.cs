using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int totalPieces = w * l;
            string command = string.Empty;
            int sum = 0;
          

            while (true)
            {

                command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{totalPieces - sum} pieces are left.");
                    return;
                }
                
                
                    int input = int.Parse(command);
                    sum += input;
                    if (sum > totalPieces)
                    {
                        Console.WriteLine($"No more cake left! You need {sum - totalPieces} pieces more.");
                        return;
                    }
                
            }
        
        }
    }
}
