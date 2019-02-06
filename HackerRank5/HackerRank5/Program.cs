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
    // Given an integer, n, print its first  multiples. Each multiple should be printed on a new line in the 
    // form: n x i = result.

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 11; i++)
        {
            int result = n * i;
            Console.WriteLine("{0} x {1} = {2}", n, i, result);
        }
        Console.ReadLine();
    }
}

