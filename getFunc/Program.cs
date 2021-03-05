using System;

namespace getFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input;
            input = Console.ReadLine();
            Console.WriteLine(input);
            int i, j, l, numPern, pernFlag, symFlag;
            i = 0;
            j = 0;
            l = 0;
            symFlag = -1;
            pernFlag = -1;
            numPern = -1;
            char c;
            char cj;
            string symb = "+-*/%";
            string pern = "()";
            string strNumPern = "";
            string subStrNumPern = "";
            char minus, plus, multi, dev, mod, pern1, pern2;
            string my = "";
            string evalPren = "";
            string numStr = "";
            while (i < input.Length)
            {
                pernFlag = -1;
                c = input[i];
                if (c == pern[0] || c == pern[1])
                {
                    strNumPern = strNumPern + i;
                    pernFlag = 0;
                }
                if (pernFlag == 0)
                {
                    while (l < strNumPern.Length)
                    {
                        if ( == input[i + strNumPern.Length])
                        {
                            pernFlag = 1;
                        }
                        if (pernFlag != -1 && pernFlag != 1)
                        {

                            subStrNumPern = subStrNumPern + (input[i + strNumPern.Length]);
                            numPern = int.Parse(subStrNumPern);
                        }
                    }
                    j = j + 1;

                }
                i = i + 1;
            }
            Console.WriteLine("String: " + strNumPern);
            Console.WriteLine("int: " + numPern);



            // int num = int.Parse(input);
            // Console.WriteLine(num);
        }
    }
}
