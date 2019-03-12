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
    /* Given set S {1,2,3,...N} .Find two integers, A and B (where A < B ), 
     * from set S such that the value of A&B is the maximum possible and 
     * also less than a given integer, K. In this case, & represents the 
     * bitwise AND operator.
     */
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            // maximum value for a & b
            int maxValue = 0;

            for (int a = 1; a < n; a++)
            {
                for (int b = a + 1; b <= n; b++)
                {
                    // store initial value in temp
                    int tempValue = a & b;

                    // if temp is greater than max, make it max
                    // temp needs to be less than k
                    if (tempValue < k && maxValue < tempValue)
                        maxValue = tempValue;

                }
            }

            Console.WriteLine(maxValue);
        }
    }
}

