using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testscores = { 95, 100, 88, 89, 23, 54, 65 };

            for (int i = 0; i < testscores.length; i++)
            {
                if (testscores[i] > 85)
                {
                    console.writeline("passing test score:" + testscores[i]);
                }
            }
            console.readline();

            string[] names = { "stan", "eric", "joe", "bob" };

            for (int j = 0; j < names.length; j++)
            {

                console.writeline(names[j]);

            }
            console.readline();

            list<int> testscores = new list<int>();
            testscores.add(98);
            testscores.add(88);
            testscores.add(95);
            testscores.add(67);
            testscores.add(27);

            foreach (int score in testscores)
            {
                if (score > 85)
                {
                    console.writeline("passing score:" + score);
                }
            }
            console.readline();

            List< string >names= new List<string> { "Dan", "Joe", "Ned", "Billy" };

            foreach (string name in names)
            {
                if (name == "Dan")
                {
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 100, 97, 98 };
            List<int> passingScores = new List<int>();
            foreach ( int score in testScores) 
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
                Console.WriteLine(passingScores.Count);
                Console.ReadLine();
            }
        }
    }
}
