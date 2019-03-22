using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int goals = 0;
            int mostGoals = 0;
            string bestPlayer = string.Empty;
            string command = string.Empty;

            while (true)
            {

                command = Console.ReadLine();
                if (command == "END")
                {
                    if (mostGoals >= 3)
                    {
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        Console.WriteLine($"He has scored {goals} goals.");
                        return;
                    }
                }
                goals = int.Parse(Console.ReadLine());
                if (goals > mostGoals)
                {
                    mostGoals = goals;
                    bestPlayer = command;
                }
                if (goals>=10)
                {
                    Console.WriteLine($"{bestPlayer} is the best player!");
                    Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
                    return;
                }
               


            }
        }
    }
}
