using System;

namespace inputExs
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            Console.WriteLine("Please insert a number to square.");
            num1 = double.Parse(Console.ReadLine());
            double result = num1 * num1;
            Console.WriteLine("Result: " + result);
            // double num2;
            // double weight;
            // string name;
            // Console.WriteLine("Please insert a number to multiplay.");
            // num1 = double.Parse(Console.ReadLine());
            // Console.WriteLine("Please insert a number to multiplay it by.");
            // num2 = double.Parse(Console.ReadLine());
            // double result = num1 * num2;
            // Console.WriteLine("I think this is the result: " + result);
            // Console.WriteLine("What is your name?");
            // name = Console.ReadLine();
            // Console.WriteLine("and your weight please.. ;) ");
            // weight = double.Parse(Console.ReadLine());
            // Console.WriteLine("Well " + name + " with a good diet you can lose up to 5 K\"G and your new weight would be: " + (weight - 5) + "K\"G");



        }
    }
}
