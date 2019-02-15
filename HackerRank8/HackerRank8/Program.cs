using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    /*
    Given n names and phone numbers, assemble a phone book that maps friends' names to their respective phone numbers. 
    You will then be given an unknown number of names to query your phone book for. For each name queried, print the associated 
    entry from your phone book on a new line in the form name=phoneNumber; if an entry for  is not found, print Not found instead
    Note: Your phone book should be a Dictionary/Map/HashMap data structure.
    */
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Dictionary<string, int> phoneBook = new Dictionary<string, int>(n);
        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            phoneBook.Add(line[0], Convert.ToInt32(line[1]));
        }

        string query = "";
        while ((query = Console.ReadLine()) != null && query != "")
        {
            if (phoneBook.ContainsKey(query))
                Console.WriteLine("{0}={1}", query, phoneBook[query]);
            else
                Console.WriteLine("Not found");
        }
    }
}

