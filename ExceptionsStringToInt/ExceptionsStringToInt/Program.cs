using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();

        try
        {
            Console.WriteLine(Int32.Parse(S));
        }
        catch (FormatException)
        {
            Console.WriteLine("Bad String");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Bad String");
        }
    }
}

