using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    /*
    Calculate the hourglass sum for every hourglass in A, then print the 
    maximum hourglass sum.
    */

    static void Main(string[] args)
    {

        int[][] matrix = new int[6][];

        // loop over input string and convert toInt
        for (int input = 0; input < 6; input++)
        {
            // fill matrix -> split ints-to32 from arr
            matrix[input] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        // current sum and max sum both initialize to 0 
        int currentSum = 0;
        int maxSum = 0;

        // loop over row for length - 2 
        for (int row = 0; row < matrix.Length - 2; row++)
        {
            // loop over columns for length - 2
            for (int col = 0; col < matrix.Length - 2; col++)
            {
                // set current sum = to references of hourGlass
                currentSum =
                    matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2]
                    + matrix[row + 1][col + 1] + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                // if current sum is greater than maxSum, set them = 
                if (currentSum > maxSum)
                    maxSum = currentSum;
            }
        }
        Console.WriteLine(maxSum);
    }
}
