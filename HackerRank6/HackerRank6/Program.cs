using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    // Given a string, print its even-indexed and odd-indexed characters as space-separated strings 
    // on a single line 
    static void Main(String[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());

        // For each string, print even indexed chars, followed by space, 
        // followed by odd-indexed chars
        for (int i = 0; i < T; i++)
        {
            char[] stringsArray = Console.ReadLine().ToCharArray();
            //Console.WriteLine(stringsArray);

            string even = string.Empty;
            string odd = string.Empty;

            for (int j = 0; j < stringsArray.Length; j++)
            {
                if (j % 2 == 0)
                    even += stringsArray[j];
                else
                    odd += stringsArray[j];

            }

            Console.WriteLine(even + " " + odd);
        }
    }
}


