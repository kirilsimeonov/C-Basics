using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins2
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            money *= 100;
            int Coins = 0;

            while (money >=200)
            {
                money -= 200;
                Coins++;
            }
            while (money >= 100)
            {
                money -= 100;
                Coins++;
            }
            while (money >= 50)
            {
                money -= 50;
                Coins++;
            }
            while (money >= 20)
            {
                money -= 20;
                Coins++;
            }
            while (money >= 10)
            {
                money -= 10;
                Coins++;
            }
            while (money >= 5)
            {
                money -= 5;
                Coins++;
            }
            while (money >= 2)
            {
                money -= 2;
                Coins++;
            }
            while (money >= 1)
            {
                money -= 1;
                Coins++;
            }
            Console.WriteLine(Coins);
        }
    }
}
