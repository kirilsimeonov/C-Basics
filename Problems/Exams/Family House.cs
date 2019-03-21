using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double months = double.Parse(Console.ReadLine());
            double electricity = 0;
            double sumElectricity = 0;
            double sumOthers = 0;
            double water = 20;
            double internet = 15;

            for (int i = 1; i <= months; i++)
            {
                electricity = double.Parse(Console.ReadLine());
                sumElectricity += electricity;
                sumOthers += (electricity + water + internet) * 1.2;
            }
            Console.WriteLine($"Electricity: {sumElectricity:f2} lv");
            Console.WriteLine($"Water: {(water * months):f2} lv");
            Console.WriteLine($"Internet: {(internet * months):f2} lv");
            Console.WriteLine($"Other: {sumOthers:f2} lv");
            double total = (sumElectricity + (water * months) + (internet * months) + sumOthers) / months;
            Console.WriteLine($"Average: {total:f2} lv");
        }
    }
}
