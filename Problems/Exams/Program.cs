using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int alpinist = int.Parse(Console.ReadLine());
            int karabineri = int.Parse(Console.ReadLine());
            int ropes = int.Parse(Console.ReadLine());
            int pikels = int.Parse(Console.ReadLine());

            double karabineriPrice = 36;
            double ropesPrice = 3.6;
            double pikelsPrice = 19.8;

            double karabineriTotal = karabineri * karabineriPrice;
            double ropesTotal = ropes * ropesPrice;
            double pikelsTotal = pikels * pikelsPrice;
            double totalSumOneAlpinist = karabineriTotal + ropesTotal + pikelsTotal;
            double totalSum = totalSumOneAlpinist * alpinist;
            Console.WriteLine($"{totalSum*1.2:f2}");

        }
    }
}
