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
    Given a base-10 integer,n, convert it to binary(base-2). 
    Then find and print the base-10 integer denoting the maximum number of consecutive 1's 
    in n's binary representation.
    */

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        // string to array so it can be split at 0
        string[] numbers = binary.Split('0').ToArray();

        //http://www.csharp-examples.net/linq-max/
        //gets length of the longest string
        int maxLength = numbers.Max(x => x.Length);

        Console.WriteLine(maxLength);
        Console.ReadLine();

    }
}

