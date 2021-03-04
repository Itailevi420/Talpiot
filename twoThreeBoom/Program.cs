using System;

namespace twoThreeBoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 1;
            int mod2;
            int mod3;
            while (i <= 100)
            {

                mod3 = i % 3;
                mod2 = i % 2;



                if (mod2 + mod3 == 0)
                    Console.WriteLine(i + ": Boom");
                else if (mod2 == 0)
                    Console.WriteLine(i + ": Bim");
                else if (mod3 == 0)
                    Console.WriteLine(i + ": Bam");
                else
                    Console.WriteLine(i);











                // if (mod2 == 0)
                // {
                //     if (mod3 == 0)
                //     {
                //         Console.WriteLine("Boom");
                //     }
                // }
                // if (mod2 == 0)
                // {
                //     Console.WriteLine(2);
                // }
                // if (mod3 == 0)
                // {

                //     Console.WriteLine(3);
                // }
                // if (mod2 != 0)
                // {
                //     if (mod3 != 0)
                //     {
                //         Console.WriteLine(i);
                //     }
                // }
                i++;

            }
        }
    }
}
