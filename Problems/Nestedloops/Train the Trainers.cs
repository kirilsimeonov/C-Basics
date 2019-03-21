using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double grade = 0;
            double average = 0;
            double sum = 0;
            int counter = 0;
            double total = 0;

            while (command!="Finish")
            {
                

                for (int i = 1; i <= n; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    average = sum / n;
                    
                    counter++;
                    
                }
                Console.WriteLine($"{command} - {average:f2}.");
                total += sum;
                sum = 0;
                average = 0;
                command = Console.ReadLine();
            }
            if (command=="Finish")
            {
                Console.WriteLine($"Student's final assessment is {total/counter:f2}.");
                return;
            }
            
           
        }
    }
}
