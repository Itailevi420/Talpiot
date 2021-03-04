using System;
using System.Linq;
namespace ternaryExs
{
    class Program
    {
        static void Main(string[] args)
        {
            // answer NOT using an array
            int? val, maxVal = null;
            int i = 0;
            string input;
            while (i < 10)
            {
                Console.WriteLine("Please enter an integer and press ENTER");
                input = Console.ReadLine();
                val = int.Parse(input);
                maxVal = maxVal > val ? maxVal : val;
                i++;
            }
            Console.WriteLine("The " + (i + 1) + " number you entered is: " + maxVal + " and it's the biggest number you entered too");
            // answer using an array
            // string input;
            // int[] myArray = new int[10];
            // int i = 0;
            // while (i < 10)
            // {
            //     Console.WriteLine("Please enter an integer and press ENTER");
            //     input = Console.ReadLine();
            //     myArray[i] = int.Parse(input);
            //     i++;
            // }

            // // answer  using methods
            // int maxValue = myArray.Max();
            // int maxIndex = myArray.ToList().IndexOf(maxValue);

            // //  answer with no methods
            // int? maxVal = null; //nullable so this works even if you have all super-low negatives
            // int index = -1;
            // for (int n = 0; n < myArray.Length; n++)
            // {
            //     int thisNum = myArray[n];
            //     if (!maxVal.HasValue || thisNum > maxVal.Value)
            //     {
            //         maxVal = thisNum;
            //         index = n;
            //     }
            // }
            // Console.WriteLine("The " + (index + 1) + " number you entered is: " + maxVal + " and it's the biggest number you entered too");
            // int biggest = a < b ? b : a;
            // int biggest2 = biggest < c ? c : biggest;
            // Console.WriteLine(biggest2 + " is the biggest number you entered");

            // int biggest;
            // // int biggest2;
            // biggest = a;
            // if (a < b)
            // {
            //     biggest = b;
            // }
            // if (biggest < c)
            // {
            //     biggest = c;
            // }
        }
    }
}
