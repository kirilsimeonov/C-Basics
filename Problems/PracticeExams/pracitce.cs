using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            if (min == 0)
            {
                Console.WriteLine("Match has just began!");
                return;
            }
            if (min < 45) Console.WriteLine("First half time.");
            if (min >= 45) Console.WriteLine("Second half time.");
            if (min > 1 && min <= 10)
            {
                    Console.WriteLine($"{name} missed a penalty.");
                    if (min % 2 == 0) Console.WriteLine($"{name} was injured after the penalty.");
            }
           if (min > 10 && min <= 35)
            {
                        Console.WriteLine($"{name} received yellow card.");
                        if (min % 2 != 0) Console.WriteLine($"{name} got another yellow card.");
           }
           if (min > 35 && min < 45)
           {
                        Console.WriteLine($"{name} SCORED A GOAL !!!");
           }
           if (min > 45 && min <= 55)
           {
                        Console.WriteLine($"{name} got a freekick.");
                        if (min % 2 == 0) Console.WriteLine($"{name} missed the freekick.");
           }
          if (min > 55 && min <= 80)
           {
                        Console.WriteLine($"{name} missed a shot from corner.");
                        if (min % 2 != 0) Console.WriteLine($"{name} has been changed with another player.");
           }
          if (min > 80 && min <= 90)
          {
                        Console.WriteLine($"{name} SCORED A GOAL FROM PENALTY !!!");
          }
                 }
            }
        }
    

