using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
           double sum = 0;
            int extra = 0;
            int pen = 0;

            for (int i = 1; i <= games; i++)
            {
                double minutes = double.Parse(Console.ReadLine());
                
               if (minutes>120)
                {
                    pen++;
                }
                else if (minutes > 90)
                {
                    extra++;
                }
                sum += minutes;

            }
            Console.WriteLine($"{name} has played {sum} minutes. Average minutes per game: {(sum/games):f2}");
            Console.WriteLine($"Games with penalties: {pen}");
            Console.WriteLine($"Games with additional time: {extra}");
        }
    }
}
