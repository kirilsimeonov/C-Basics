using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            double sumName = 0;
            double maxName = 0;
            string winner = string.Empty;

            while (name!="STOP")
            {
                name = Console.ReadLine();
                if (name=="STOP")
                {
                    break;
                }
                
                for (int i = 0; i < name.Length; i++)
                {
                    sumName += name[i];
                }
                if (sumName>maxName)
                {
                    maxName = sumName;
                    winner = name;
                }
                sumName = 0;

            }
            Console.WriteLine($"Winner is {winner} - {maxName}!");
           

            
        }
    }
}
