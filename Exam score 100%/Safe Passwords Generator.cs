using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counter = 0;


            for (char i = (char)35; i <= (char)55; i++)
            {

                for (char j = (char)64; j <= (char)96; j++)
                {

                    for (int k = 1; k <= a; k++)
                    {
                        for (int f = 1; f <= b; f++)
                        {

                            counter++;
                            char n = i;
                            Console.Write($"{i}{j}{k}{f}{j}{n}|");
                            
                            if (i==(char)55)
                            {
                                i = (char)34;
                            }
                            if (j==(char)96)
                            {
                                j = (char)63;
                            }
                            i++; j++;

                            if (a * b == counter)
                           {
                               return;
                           }
                            if (counter == max)

                            {
                                return;
                            }

                        }
                    }
                }
            }


        }
    }
}
