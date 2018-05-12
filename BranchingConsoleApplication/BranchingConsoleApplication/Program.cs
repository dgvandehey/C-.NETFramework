using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number");
            int favNum = Convert.ToInt32(Console.ReadLine());
            string name = favNum == 12 ? "You have a cool favorite number" : "You do not have a cool number";
            Console.WriteLine(name);
            Console.ReadLine();

            int roomTemperature = 70;
            Console.WriteLine("Hi What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi" + name+"What is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());
            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("Damn its hot in here");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("its not bad in here");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            //int currentTemperature = 100  ;
            //int roomTemperature = 110;
            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp" : "It is not room temp";
            //Console.WriteLine(comparisonResult);
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is room temperature");
            //}
            //else if(currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It certainly is room temperature. It seems warmer than the current");
            //}
            //else
            //{
            //    Console.WriteLine("It is not room temperature");
            //}
            Console.ReadLine();
        }
    }
}
