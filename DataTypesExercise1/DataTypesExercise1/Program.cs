using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int userInputOne = 10;
            int total = userInputOne * 50;
            Console.WriteLine(total);
            Console.ReadLine();

            int inputOne = 75;
            int totalNumber = inputOne + 25;
            Console.WriteLine(totalNumber);
            Console.ReadLine();
            
            double userOne = 20.5;
            double dividedNumber = userOne / 12.5;
            Console.WriteLine(dividedNumber);
            Console.ReadLine();

            double firstNumberComparison = 30.5;
            int secondNumberComparison = 50;
            bool trueOrFalse = firstNumberComparison > secondNumberComparison;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

            int remainder = 7 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            bool comparisonOne = 3 > 2;
            bool comparisonTwo = 5 > 4;
            bool combinedComparison = comparisonOne && comparisonTwo;
            Console.WriteLine(combinedComparison);
            Console.WriteLine(comparisonOne);
            Console.WriteLine(comparisonTwo);
            Console.ReadLine();

            int numberOne = 2;
            int numberTwo = 2;
            int combinedNumber = numberOne+numberTwo;
            bool numberComparison = combinedNumber != 4;
            Console.WriteLine(numberComparison);
            Console.ReadLine();

            

        }
    }
}
