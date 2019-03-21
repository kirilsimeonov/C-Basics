using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string ingredient = string.Empty;
            bool sugar = false;
            bool flour = false;
            bool eggs = false;


            for (int i = 1; i <= num; i++)
            {


                while (true)
                {
                    ingredient = Console.ReadLine();
                    if (ingredient == "sugar")
                    { 
                        sugar = true;
                    }
                    if (ingredient =="flour")
                    {
                        flour = true;
                    }
                    if (ingredient=="eggs")
                    {
                        eggs = true;
                    }
                    if (ingredient=="Bake!")
                    {
                        if (sugar==true && flour == true && eggs==true)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            sugar = false;
                            flour = false;
                            eggs = false;
                            break;
                        }
                        else
                        {
                            
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            
                        }
                        
                    }
                    
                }
                


            }
        }
    }
}
