using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank1
{
  
    class Solution
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int j;
            double inputDouble;
            string inputString;

            // Read and save an integer, double, and String to your variables.
            j = Convert.ToInt32(Console.ReadLine());
            inputDouble = Convert.ToDouble(Console.ReadLine());
            inputString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            int k = i + j;
            Console.WriteLine(k);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:.0}", d + inputDouble);


            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + inputString);

            Console.ReadLine();

        }
    }
}
