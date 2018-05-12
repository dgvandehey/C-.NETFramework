using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Concatenate three strings.
            string name = "Dustin Vandehey";
            string school = "Tech Academy";
            string occupation = "Slacker";
            Console.WriteLine(name + " is a student at " + school + " and is a " + occupation);
            Console.ReadLine();

            //2.Convert a string to uppercase.
            string name = "dustin";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();
            //3.Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello my name is Dustin Vandehey. ");
            sb.Append("I was born in Portland Oregon. ");
            sb.Append("I am currently a student at the Tech Academy. ");
            sb.Append("I am currently learning C# the .NET Framework, and Visual Studio. ");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
