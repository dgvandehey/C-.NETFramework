using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //int otherDifference = 20 - 4;
            //int combined = difference - otherDifference;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int product = 20 * 5;
            //int otherProduct = 30 * 5;
            //int combinedProduct = product * otherProduct;
            //Console.WriteLine(combinedProduct);
            //Console.ReadLine();

            //double quotient = 20.0 / 5.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 21 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();
            int roomTemperature = 70;
            int currentTemperature = 70;
            //bool isWarm = currentTemperature <= roomTemperature;
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
