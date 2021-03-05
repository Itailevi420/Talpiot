using System;

namespace starPir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 0;
            Console.WriteLine("Please enter a number and press ENTER...");
            string input = Console.ReadLine();
            num = int.Parse(input);
            int i, j, itr, firstAst, lastAst;
            j = num + (num - 1);
            i = 0;
            itr = 1;
            firstAst = num - 2;
            lastAst = num;
            while (itr < num)
            {
                while (i < j)
                {
                    if (i == num - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                    i = i + 1;
                }
                i = 0;
                Console.WriteLine(" ");
                while (i < j)
                {
                    if (i == firstAst || i == lastAst)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                    i = i + 1;
                }
                lastAst = lastAst + 1;
                firstAst = firstAst - 1;
                itr = itr + 1;
            }
            // while (i < j)
            // {
            //     if (i == num - 1)
            //     {
            //         Console.Write("*");
            //     }
            //     else
            //     {

            //         Console.Write("+");
            //     }
            //     i = i + 1;

            // }

            // while (i < num - 1)
            // {
            //     Console.Write("+");
            //     i = i + 1;
            // }
            // Console.Write("*");
            // i = 0;
            // while (i < num - 1)
            // {

            //     Console.Write("+");
            //     i = i + 1;

            // }


        }
    }
}
