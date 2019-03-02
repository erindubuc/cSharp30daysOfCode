using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Solution
{
    static Queue<Node> bstQ = new Queue<Node>();

    static void levelOrder(Node root)
    {
        // add bst root to queue
        bstQ.Enqueue(root);

        // load rest of data into bst
        // while queue count is not 0
        while (bstQ.Count > 0)
        {
            // remove oldest element from start
            var current = bstQ.Dequeue();
            // write it to the line
            Console.Write(current.data + " ");

            if (current.left != null)
                // enter left-side node
                bstQ.Enqueue(current.left);

            if (current.right != null)
                // enter right side node
                bstQ.Enqueue(current.right);
        }
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }
    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        levelOrder(root);

    }
}
