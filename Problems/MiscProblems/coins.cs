using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double balance = input * 100;
            int counter = 0;
           
            
                
                while (balance>=200)
                {
                    
                    balance -= 200;
                    counter++;

                }
                if (balance>=100)
                {
                    
                    balance -= 100;
                    counter++;
                }
                if (balance>=50)
                {
                    
                    balance -= 50;
                    counter++;
                }
               
                while (balance>=20)
                {
                    
                    balance -= 20;
                    counter++;
                }
                if (balance>=10)
                {
                    
                    balance -= 10;
                    counter++;
                }

                if (balance>=5)
                {
                    
                    balance -= 5;
                    counter++;
                }
               
                while (balance>=2)
                {
                    counter++;
                    balance -= 2;
                    
                }
                if (balance>=1)
                {
                    counter++;
                    balance -= 1;
                    
                    
                }
                
            
            Console.WriteLine(counter);
        }
    }
}
