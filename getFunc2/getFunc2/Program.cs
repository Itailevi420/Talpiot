using System;

namespace getFunc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your formula..");
            String input, leftFromMulti, rightFromMulti, plusChar;
            input = Console.ReadLine();
            char symbLeftFromMulti, symbReg;
            plusChar = "";
            symbReg = '?';
            symbLeftFromMulti = '?';
            rightFromMulti = "";
            leftFromMulti = "";
            int i, multiP, regP, regPP;
            double resultMulti, intRightFromMulti, intLeftFromMulti, intPlusChar, sum;
            sum = 0;
            resultMulti = 0;
            multiP = -1;
            i = 0;
            while (i < input.Length)
            {
                if (input[i] == '*' || input[i] == '/' || input[i] == '%')
                {
                    multiP = i;
                    while (i < input.Length)
                    {
                        if (i + 1 <= input.Length - 1)
                        {
                            if (!(input[i + 1] == '-' || input[i + 1] == '+' || input[i + 1] == '*' || input[i + 1] == '/' || input[i + 1] == '%'))
                            {
                                rightFromMulti = rightFromMulti + input[i + 1];
                            }
                            else
                            {
                                i = input.Length;
                            }
                        }
                        i = i + 1;
                    }
                    i = multiP;
                    while (i > 0)
                    {

                        if (resultMulti != 0)
                        {

                            leftFromMulti = "" + resultMulti;
                            resultMulti = 0;
                        }
                        else if (!(input[i - 1] == '-' || input[i - 1] == '+' || input[i - 1] == '*' || input[i - 1] == '/' || input[i - 1] == '%'))
                        {
                            leftFromMulti = input[i - 1] + leftFromMulti;

                        }
                        else
                        {
                            symbLeftFromMulti = input[i - 1];
                            i = -1;
                        }

                        i = i - 1;
                    }
                    i = multiP;
                    intLeftFromMulti = double.Parse(leftFromMulti);
                    intRightFromMulti = double.Parse(rightFromMulti);
                    rightFromMulti = "";
                    leftFromMulti = "";
                    if (symbLeftFromMulti == '-')
                    {
                        if (input[multiP] == '*')
                        {
                            resultMulti = resultMulti - intLeftFromMulti * intRightFromMulti;
                        }
                        else if (input[multiP] == '/')
                        {
                            resultMulti = resultMulti - intLeftFromMulti / intRightFromMulti;
                        }
                        else if (input[multiP] == '%')
                        {
                            resultMulti = resultMulti - intLeftFromMulti % intRightFromMulti;
                        }
                    }
                    else
                    {

                        if (input[multiP] == '*')
                        {
                            resultMulti = resultMulti + intLeftFromMulti * intRightFromMulti;
                        }
                        else if (input[multiP] == '/')
                        {
                            resultMulti = resultMulti + intLeftFromMulti / intRightFromMulti;
                        }
                        else if (input[multiP] == '%')
                        {
                            resultMulti = resultMulti + intLeftFromMulti % intRightFromMulti;
                        }
                    }
                    // }
                }


                i = i + 1;
            }
            i = 0;
            // Console.WriteLine("resultMulti: " + resultMulti);
            while (i < input.Length)
            {
                if (input[i] == '+' || input[i] == '-')
                {
                    regP = i;
                    regPP = i;
                    while (i > 0)
                    {
                        if (input[i - 1] == '*' || input[i - 1] == '/' || input[i - 1] == '%')
                        {
                            plusChar = "";
                            i = 0;
                        }
                        else if (!(input[i - 1] == '-' || input[i - 1] == '+'))
                        {
                            plusChar = input[regPP - 1] + plusChar;
                            regPP = regPP - 1;
                        }
                        else if (input[i - 1] == '-' || input[i - 1] == '+')
                        {
                            symbReg = input[i - 1];
                            i = 0;
                        }
                        i = i - 1;
                    }

                    i = regP;
                    if (plusChar != "")
                    {
                        intPlusChar = double.Parse(plusChar);
                        plusChar = "";
                        if (symbReg == '-')
                        {
                            sum = sum - intPlusChar;
                        }
                        else
                        {
                            sum = sum + intPlusChar;
                        }
                    }
                }

                i = i + 1;
            }
            // Console.WriteLine("sum: " + sum);
            Console.WriteLine(sum + resultMulti);
        }
    }
}
