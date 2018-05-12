using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 35;
            int friendsAge = 36;
            if (myAge == friendsAge)
            {
                Console.WriteLine("That can't be");
            }
            else if (myAge > friendsAge)
            {
                Console.WriteLine("I dont think I am older than my friend, but I will take it");
            }
            else if (myAge < friendsAge)
            {
                Console.WriteLine("That seems more like it. He is older than I am");
            }
            else
            {
                Console.WriteLine("There must be an error");
            }

            Console.WriteLine("How many books do you own");
            int bookNum = Convert.ToInt32(Console.ReadLine());
            string bookAmount = bookNum == 100 ? "You have the same amount of books as I have" : "You do not have the same amount.";
            Console.WriteLine(bookAmount);
            Console.ReadLine();

            
        }
    }
}
