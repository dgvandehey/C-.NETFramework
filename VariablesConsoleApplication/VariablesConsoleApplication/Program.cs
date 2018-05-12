using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your Favorite Number plus 5 is:" + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -43;
            char questionMark='\u2103';

            decimal moneyInBand = 1.2m;
            double heightInCentimeters = 3232.345;
            float secondsLeftInGame = 2.4f;
            short temperatureOnPlut0 = -343;
            string myName = "Dustin";
            int currentAge = 36;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string weatherStatus = Convert.ToString(isRaining);

            Console.WriteLine(weatherStatus);
            Console.ReadLine();


        }

    }
}
