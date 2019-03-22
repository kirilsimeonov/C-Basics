using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            double grade = 0;
            int counter = 1;
            double sum = 0;
            int fail = 0;

            while (counter<=12)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum = sum + grade;
                    counter++;
                }
                if (grade <4)
                {
                    fail++;
                }
                if (fail>1)
                {
                    Console.WriteLine($"{student} has been excluded at {counter} grade");
                    break;
                }
            }

            if (fail < 2)

            {
                Console.WriteLine($"{student} graduated. Average grade: {sum / 12:f2}");
            }
           
            
           
        }
    }
}
