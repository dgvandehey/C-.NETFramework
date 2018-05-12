using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some text");
            
            string[] guitars = { "Gibson", "Fender", "Jackson", "Martin", "Chapman" };
            for (int i = 0; i < guitars.Length; i++)
            {
                
                
                    Console.WriteLine(guitars[i]);
             

                

            }
            Console.ReadLine();
        }
    }
}
