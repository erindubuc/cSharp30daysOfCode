﻿using System;
using System.Collections.Generic;
using System.IO;

abstract class Book
{
    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();

}

// Create MyBook Class that inherits from Book and implements the abstract display() method 

class MyBook : Book
{
    public int price;

    public MyBook(String t, String a, int p)
        : base(t, a)
    {
        this.price = p;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}

class Solution
{
    static void Main(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}