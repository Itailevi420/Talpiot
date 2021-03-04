using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
            string input = Console.ReadLine();
            Regex r = new Regex(@"[a-z]+");
            while (string.IsNullOrEmpty(input) || r.IsMatch(input))
            {
                Console.WriteLine("Please enter a valid number");
                input = Console.ReadLine();
            }
            int inputNum = int.Parse(input);
            Console.WriteLine(space);
            Console.WriteLine("Try to guess the number :)....");
            int inputPlayer = -1;
            int counter = 0;
            int inputPlayerLast = -1;
            int diff = 0;
            int diffLast = 0;
            // can do this way too but don't really understand the consept
            // int? inputPlayer = null;


            while (!(inputPlayer == inputNum))
            {
                if (inputPlayer != -1)
                {
                    if (inputPlayerLast == -1 || inputPlayerLast == inputPlayer)
                        Console.WriteLine("!!!טעות");
                    else if (inputNum < inputPlayer)
                        diff = inputPlayer - inputNum;
                    else
                        diff = inputNum - inputPlayer;
                    if (inputPlayerLast != -1 && inputPlayer != inputPlayerLast)
                    {
                        if (inputNum < inputPlayerLast)
                            diffLast = inputPlayerLast - inputNum;
                        else
                            diffLast = inputNum - inputPlayerLast;
                        if (diffLast > diff)
                            Console.WriteLine("!!!מתחמם");
                        else
                            Console.WriteLine("!!!מתקרר");
                    }
                }

                inputPlayerLast = inputPlayer;
                counter++;
                inputPlayer = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Congratulations your guess is correct ! ! !");
            Console.WriteLine("It took you only " + counter + " guesses.");
            // Console.WriteLine("Congratulations your guess is correct ! ! !");
            // Console.WriteLine("It took you only " + counter + " guesses.");

            // inputPlayerLast = inputPlayer;
            // inputPlayer = int.Parse(Console.ReadLine());
            // Console.WriteLine("inputPlayer: " + inputPlayer);
            // Console.WriteLine("inputPlayerLast: " + inputPlayerLast);
        }
    }
}
