using System;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class Solution
{

    public static Node insert(Node head, int data)
    {
        // create a new node
        Node newNode = new Node(data);
        // place head into a 'current' node 
        Node current = head;

        if (head == null)
        {
            // get first node
            return newNode;
        }
        else
        {
            while (current.next != null)// head/current != null
            {
                current = current.next; // current now points to next current 
            }

        }
        // pointing to newNode of data
        current.next = newNode;
        return head;
    }

    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    static void Main(String[] args)
    {

        Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        display(head);
        Console.ReadLine();
    }
}
