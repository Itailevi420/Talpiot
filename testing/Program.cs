using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool f;
            bool b;
            while (i < 100)
            {
                i = i + 1;
                f = i % 3 != 0;
                b = i % 5 != 0;
                Console.WriteLine(i + ": " + (f ? "" : "Fizz") + (b ? "" : "Buzz"));
            }
        }
    }
}

