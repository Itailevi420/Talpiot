using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5 + 4 * 3 + 2 % 5 + 8;
            b = c = a;
            // Console.Write("well I think " + number + " is not " + (a + b));
            Console.WriteLine(" we will succeed");
            Console.WriteLine("well that didn't age well!!!");
            Console.WriteLine("a is equal to " + (5 + 4 * 3 + 2 % 5 + 8));

            Console.WriteLine(4 * 5 + "" + 54 * 1 + 5 / 4 + 2 % 3);
            // Console.WriteLine("a: " + a);
            // Console.WriteLine("b: " + b);
            // Console.WriteLine("c: " + c);
            // user input
            string name;
            Console.WriteLine("Please insert your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " it's very nice to meet you ! ! !");

        }
    }
}
