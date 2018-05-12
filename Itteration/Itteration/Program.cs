using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 22, 56, 90, 88, 100 };
            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing Test Score: " + testScores[i]);
                }
            }
            Console.ReadLine();
            string[] names = { "Bob", "Julie", "Dustin", "Eric" };
            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Dustin")
                {
                    Console.WriteLine(names[j]);
                }
            }
            Console.ReadLine();
            string[] names = { "Jerry", "John", "Bob", "Gerry", "Booboo" };
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Jerry")
                {
                    Console.WriteLine(names[i]);
                }
            }
            Console.ReadLine();
            string[] guitars = { "Les Paul", "Chapman", "Strat", "Martin" };
            for (int i = 0; i < guitars.Length; i++)
            {
                Console.WriteLine(guitars[i]);
            }
            Console.ReadLine();
            List<int> testScores = new List<int>();
            testScores.Add(39);
            testScores.Add(45);
            testScores.Add(28);
            testScores.Add(11);
            testScores.Add(99);
            testScores.Add(18);

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("This is a passing score: " + score);
                }
                else
                {
                    Console.WriteLine("Not a passing score: " + score);
                }
            }
            Console.ReadLine();

            List<int> ageNumber = new List<int>();
            ageNumber.Add(24);
            ageNumber.Add(55);
            ageNumber.Add(35);
            ageNumber.Add(99);
            ageNumber.Add(110);

            foreach (int ages in ageNumber)
            {
                if (ages > 90)
                {
                    Console.WriteLine("Congrats on making it this far with your age: " + ages);
                }
                else if (ages < 30)
                {
                    Console.WriteLine("You have a long way to go at: " + ages);
                }
                else
                {
                    Console.WriteLine("middle age folks at: " + ages);
                }
            }
            Console.ReadLine();
            List<int> gameScores = new List<int>();
            gameScores.Add(150);
            gameScores.Add(200);
            gameScores.Add(30);
            gameScores.Add(250);
            gameScores.Add(300);
            gameScores.Add(140);

            foreach (int scores in gameScores)
            {
                if (scores > 290)
                {
                    Console.WriteLine("Hgh Score: " + scores);
                }

                else if (scores > 30)
                {
                    Console.WriteLine("Semi High Score: " + scores);
                }
                else
                {
                    Console.WriteLine("No Ranking");
                }
            }
            Console.ReadLine();
            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23,99};
            List<int> passingScores = new List<int>();
            foreach(int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
