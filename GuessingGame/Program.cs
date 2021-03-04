using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hello = @" 
                    __  __     ____    
                   / / / /__  / / /___ 
                  / /_/ / _ \/ / / __ \
                 / __  /  __/ / / /_/ /
                /_/ /_/\___/_/_/\____/ 
                            ";
            string space = @" 
                               ___  ___ 
                              /__ \/__ \
                              / _/ / _/
                             /_/  /_/  
                            (_)  (_)

                               ___  ___ 
                              /__ \/__ \
                              / _/ / _/
                             /_/  /_/  
                            (_)  (_)
                               ___  ___ 
                              /__ \/__ \
                              / _/ / _/
                             /_/  /_/  
                            (_)  (_)
                               ___  ___ 
                              /__ \/__ \
                              / _/ / _/
                             /_/  /_/  
                            (_)  (_)
                               ___  ___ 
                              /__ \/__ \
                              / _/ / _/
                             /_/  /_/  
                            (_)  (_)
                               ___  ___ 
                              /__ \/__ \
                              / _/ / _/
                             /_/  /_/  
                            (_)  (_)
                            ";
            Console.WriteLine(Hello);
            Console.WriteLine("And Wellcom to the Guessing Game!");
            Console.WriteLine(" ");
            Console.WriteLine("Please Enter a Number between 0 and 100 and press ENTER.");
            int inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine(space);
            Console.WriteLine("Try to guess the number :)....");
            int inputPlayer = -1;
            int counter = 0;
            // can do this way too but don't really understand the consept
            // int? inputPlayer = null;
            while (!(inputPlayer == inputNum))
            {

                counter++;
                inputPlayer = int.Parse(Console.ReadLine());
                if (inputPlayer < inputNum)
                    Console.WriteLine("try a begger number");
                else //if (inputPlayer > inputNum)
                    Console.WriteLine("try a smaller number");


                if (inputPlayer == inputNum)
                {
                    Console.WriteLine("Congratulations your guess is correct ! ! !");
                    Console.WriteLine("It took you only " + counter + " guesses.");
                }
            }
            // Console.WriteLine("Congratulations your guess is correct ! ! !");
            // Console.WriteLine("It took you only " + counter + " guesses.");

        }
    }
}
