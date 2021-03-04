using System;

namespace loopsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int counter = 0;
            while (counter <= 100)
            {
                i = i + counter;
                ++counter;
            }
            Console.WriteLine(i);
            Console.WriteLine(counter);

        }
    }
}
