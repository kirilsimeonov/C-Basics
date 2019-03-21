using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            
            int people = 0;
            int price = 0;
            double sum = 0;
            int sumPeople = 0;
            string command = Console.ReadLine();

            while (command!="The restaurant is full")
            {
                people = int.Parse(command);
                if (people<5)
                {
                    price = 100;
                }
                else if (people>=5)
                {
                    price = 70;
                }
                sum += people * price;
                sumPeople += people;
                command = Console.ReadLine();


            }
            if (command=="The restaurant is full")
            {
                if (sum>=budget)
                {
                    Console.WriteLine($"You have {sumPeople} guests and {sum-budget} leva left.");
                }
                else if (budget>sum)
                {
                    Console.WriteLine($"You have {sumPeople} guests and {sum} leva income, but no singer.");
                }
            }
        }
    }
}
