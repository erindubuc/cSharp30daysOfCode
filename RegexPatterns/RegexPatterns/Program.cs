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
    /*Consider a database table, Emails, which has the attributes First Name and 
     Email ID. Given N rows of data simulating the Emails table, print an 
     alphabetically-ordered list of people whose email address ends in @gmail.com. 
     */

    static List<string> names = new List<string>();

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        Regex pattern = new Regex(@".+@gmail\.com");

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');

            string firstName = firstNameEmailID[0];

            string emailID = firstNameEmailID[1];

            if (pattern.IsMatch(emailID))
            {
                names.Add(firstName);

            }

        }

        names.Sort();

        foreach (var name in names)
            Console.WriteLine(name);
    }
}
