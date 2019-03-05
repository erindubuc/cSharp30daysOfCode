using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {

            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            foreach (int n in numbers)
                Console.WriteLine(Primality(n));
        }
    }

    /* A prime is a natural number greater than 1 that has no positive divisors other 
     * than 1 and itself. Given a number,n, determine and print whether it's Prime or
     * Not prime
     * If possible, try to come up with a O(log N) primality algorithm
    */
    static string Primality(int n)
    {
        if (n == 1)
            return "Not prime";

        // loop to check whether divisible by 2 and 3
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return "Not prime";
        }

        return "Prime";
    }
}
