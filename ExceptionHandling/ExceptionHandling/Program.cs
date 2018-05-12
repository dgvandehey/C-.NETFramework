using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Pick a number ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Devide these two numbers");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + "Devided by" + numberTwo + "equals" + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type in a whole numer");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dont devide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
