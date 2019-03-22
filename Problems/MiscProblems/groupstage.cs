using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStage
{
    class Program
    {
        public static void Main()
        {

            string teamName = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());
            int counter = 0;
            int goalsScored = 0;
            int goalsConceded = 0;
            int sumScored = 0;
            int sumConceded = 0;
            int points = 0;


            while (counter < matches)
            {
                goalsScored = int.Parse(Console.ReadLine());
                goalsConceded = int.Parse(Console.ReadLine());
                counter++;
                sumScored += goalsScored;
                sumConceded += goalsConceded;
                if (goalsScored > goalsConceded)
                {
                    points += 3;
                }
                else if (goalsScored == goalsConceded)
                {
                    points += 1;
                }
                else if (goalsScored < goalsConceded)
                {
                    points += 0;
                }

            }
            if (sumScored >= sumConceded)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {sumScored - sumConceded}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {sumScored - sumConceded}.");
            }
        }
    }
}

