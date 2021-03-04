using System;

namespace factorialInp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a integer to see it factorial value:");
            // takes input from user
            string input = Console.ReadLine();

            // < int.Parse() > changes the type of the input to int from string
            int n = int.Parse(input);
            int i = 1;
            int result = 1;
            while (i <= n)
            {
                result = result * i;
                ++i;

            }
            Console.WriteLine(result);
        }
    }
}
