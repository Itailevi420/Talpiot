using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            int age;
            Console.WriteLine("Please enter your name...");
            // Reads line from stdin as String
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + ", Please enter your city...");
            // Reads line from stdin as String
            city = Console.ReadLine();
            Console.WriteLine("Well hello there " + name + " how is the weather in " + city + '?');
            Console.WriteLine("Please enter your age...");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("in five ears you will be " + (age + 5));
        }
    }
}
