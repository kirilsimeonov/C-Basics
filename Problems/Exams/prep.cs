using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {

            int failNumber = int.Parse(Console.ReadLine());
            int grade = 0;
            int badGrades = 0;
            int numberProblems = 0;
            string project = string.Empty;
            string command = string.Empty;
            double sum = 0;

            while (command!="Enough")
            {
                command = Console.ReadLine();
                if (command == "Enough")
                {
                    Console.WriteLine($"Average score: {sum / numberProblems:f2}");
                    Console.WriteLine($"Number of problems: {numberProblems}");
                    Console.WriteLine($"Last problem: {project}");
                    return;
                }
                grade = int.Parse(Console.ReadLine());
                sum += grade;
                numberProblems++;
                project = command;

                if (grade<=4)
                {
                    badGrades++;
                }
                if (badGrades==failNumber)
                {
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    return;
                }
                

            }
            
        }
    }
}
