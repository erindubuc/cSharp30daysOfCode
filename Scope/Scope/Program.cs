using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    //class constructor that takes an array of integers as a param 
    // and saves it to the  instance variable.
    public Difference(int[] a)
    {
        this.elements = a;
    }
    // computeDifference method that finds the maximum absolute difference 
    // between any 2 numbers in N and stores it in the maxDiff instance variable.
    public int computeDifference()
    {
        // elements in array - sort to find smallest and largest nums
        int min = elements.Min();
        int max = elements.Max();
        maximumDifference = max - min;
        // subtract their difference to get maxdiff
        return maximumDifference;
    }
}

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}