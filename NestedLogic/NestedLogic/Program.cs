using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static void Main(String[] args)
    {
        /*  Given the expected and actual return dates for a library book, create a program 
         *  that calculates the fine (if any). --> using Nested Logic

        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        var actual = Console.ReadLine().Split(' ');
        var expected = Console.ReadLine().Split(' ');

        int fine = LibraryFees(actual, expected);
        Console.WriteLine(fine);
        Console.ReadLine();

    }

    static int LibraryFees(string[] actual, string[] expected)
    {
        int actualDay = int.Parse(actual[0]);
        int actualMonth = int.Parse(actual[1]);
        int actualYear = int.Parse(actual[2]);

        int expectedDay = int.Parse(expected[0]);
        int expectedMonth = int.Parse(expected[1]);
        int expectedYear = int.Parse(expected[2]);


        // returned after year expected, fixed fine of 10000 Hackos
        if (actualYear > expectedYear)
            return 10000;

        // returned after day but still within expcted month and year,
        // fine = 15 Hackos * number of days late
        if (actualYear == expectedYear)
        {
            if (actualMonth == expectedMonth && actualDay > expectedDay)
                return 15 * (actualDay - expectedDay);

            // returned after expected month but within same calendar year
            // fine = 500 Hackos * number of months late
            if (actualMonth > expectedMonth)
                return 500 * (actualMonth - expectedMonth);
        }
        return 0;
    }
}
