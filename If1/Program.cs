using System;

namespace If1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a floating point number:");
            string input;
            input = Console.ReadLine();
            double number = double.Parse(input);
            Console.WriteLine("Please enter a second floating point number:");
            input = Console.ReadLine();
            double number2 = double.Parse(input);

            if (number + number2 > 10.5 && number - number2 < 5.3)
            {
                Console.WriteLine(number + " + " + number2 + " > 10.5, " + number + " - " + number2 + " < 5.3");
            }
            else
            {
                Console.WriteLine("thats a nice name :)");
            }

        }
    }
}
