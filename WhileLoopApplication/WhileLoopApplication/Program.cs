using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year is it?");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = year==2018;

            while (!isGuessed)
            {
                switch (year)
                {
                    case 1990:
                        Console.WriteLine("Nice guess but incorrect");
                        Console.WriteLine("Try another year");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2000:
                        Console.WriteLine("Nice guess. Getting closer");
                        Console.WriteLine("Try again");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2014:
                        Console.WriteLine("Nice guess. Almost there");
                        Console.WriteLine("Try another year");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2018:
                        Console.WriteLine("It is 2018 nice guess");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Nice guess but still incorrect");                      
                        break;
                }
                Console.Read();

                do
                {
                    Console.WriteLine("What year is it?");
                    int year = Convert.ToInt32(Console.ReadLine());
                    bool isGuessed = year == 2018;

                    while (!isGuessed)
                    {
                        switch (year)
                        {
                            case 1990:
                                Console.WriteLine("Nice guess but incorrect");
                                Console.WriteLine("Try another year");
                                year = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2000:
                                Console.WriteLine("Nice guess. Getting closer");
                                Console.WriteLine("Try again");
                                year = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2014:
                                Console.WriteLine("Nice guess. Almost there");
                                Console.WriteLine("Try another year");
                                year = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2018:
                                Console.WriteLine("It is 2018 nice guess");
                                isGuessed = true;
                                break;
                            default:
                                Console.WriteLine("Nice guess but still incorrect");
                                break;
                        }
                        Console.Read();
                    }
            }
        }
    }
}
