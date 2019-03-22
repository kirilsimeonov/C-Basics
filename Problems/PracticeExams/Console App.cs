using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStatisticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuti = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            if (minuti == 0)
            {
                Console.WriteLine("Match has just began!");
                return;
            }
            if (minuti < 45) Console.WriteLine("First half time.");
            if (minuti >= 45) Console.WriteLine("Second half time.");
            if (minuti > 1 && minuti <= 10)
            {
                Console.WriteLine($"{name} missed a penalty.");
                if (minuti % 2 == 0) Console.WriteLine($"{name} was injured after the penalty.");
            }
            if (minuti > 10 && minuti <= 35)
            {
                Console.WriteLine($"{name} received yellow card.");
                if (minuti % 2 != 0) Console.WriteLine($"{name} got another yellow card.");
            }
            if (minuti > 35 && minuti < 45) Console.WriteLine($"{name} SCORED A GOAL !!!");
            if (minuti > 45 && minuti <= 55)
            {
                Console.WriteLine($"{name} got a freekick.");
                if (minuti % 2 == 0) Console.WriteLine($"{name} missed the freekick.");
            }
            if (minuti > 55 && minuti <= 80)
            {
                Console.WriteLine($"{name} missed a shot from corner.");
                if (minuti % 2 != 0) Console.WriteLine($"{name} has been changed with another player.");
            }
            if (minuti > 80 && minuti <= 90) Console.WriteLine($"{name} SCORED A GOAL FROM PENALTY !!!");
        }
    }
}
