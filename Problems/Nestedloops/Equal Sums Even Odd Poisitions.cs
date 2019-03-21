using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums_Even_Odd_Poisitions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            
            for (int i = n1; i <= n2; i++)
            {
                string s1 = i.ToString();
                int odd1 = (int)s1[0];
                int odd2 = (int)s1[2];
                int odd3 = (int)s1[4];
                int even1 = (int)s1[1];
                int even2 = (int)s1[3];
                int even3 = (int)s1[5];
                if (odd1+odd2+odd3==even1+even2+even3)
                {
                    Console.Write(i+" ");
                }
               
            }
        }  
    }
}
