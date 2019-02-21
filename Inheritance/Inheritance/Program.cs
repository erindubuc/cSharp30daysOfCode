using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

/*
Complete the Student class by writing the following:
A Student class constructor, which has 4 parameters:
A string, firstName
A string, lastNam.
An integer, id
An integer array(or vector) of test scores, scores
A char calculate() method that calculates a Student object's average and returns the grade 
character representative of their calculated average (a):
O 90 <= a <=100
E 80 <= a < 90
A 70 <= a < 80
P 55 <= a < 70
D 40 <= a < 55
T a < 40
*/
class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int id, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
    }
    
    public char Calculate()
    {
        int total = 0;
        for (int i = 0; i < testScores.Length; i++)
        {
            total += testScores[i];
        }
        int average = total / testScores.Length;

        if (average >= 90 && average <= 100)
            return 'O';
        else if (average >= 80 && average < 90)
            return 'E';
        else if (average >= 70 && average < 80)
            return 'A';
        else if (average >= 55 && average < 70)
            return 'P';
        else if (average >= 40 && average < 55)
            return 'D';
        else
            return 'T';

    }
}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}
