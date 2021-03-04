using System;

namespace loopsEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 49;
            while (i < 199)
            {
                i = i + 2;
                Console.WriteLine("is " + i + " an ood number? " + (i % 2 != 0));
            }
        }
    }
}
