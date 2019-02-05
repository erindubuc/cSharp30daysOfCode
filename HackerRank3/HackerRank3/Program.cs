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
    // Given an integer n, perform the following conditional actions:

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        weird(N);
        Console.ReadLine();
    }

    static void weird(int N)
    {
        // If odd, print Weird
        if (N % 2 != 0)
            Console.WriteLine("Weird");
        // If even and in the inclusive range of 2 to 5, print Not Weird
        else if (N >= 2 && N <= 5)
            Console.WriteLine("Not Weird");
        // If even and in the inclusive range of 6 to 20, print Weird
        else if (N >= 6 && N <= 20)
            Console.WriteLine("Weird");
        // If even and greater than 20, print Not Weird
        else
            Console.WriteLine("Not Weird");
    }

}
