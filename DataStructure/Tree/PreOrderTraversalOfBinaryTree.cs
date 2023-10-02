using System;
using System.Collections.Generic;

class TreeNode {
    public int data;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int data) {
        this.data = data;
        left = null;
        right = null;
    }
}

class Solution {
    public static void PreOrderTraversal(TreeNode root) {
        if (root != null) {
            Console.Write(root.data + " ");
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
        }
    }

    public static TreeNode BuildBinaryTree(string input) {
        if (string.IsNullOrEmpty(input)) {
            return null;
        }

        string[] values = input.Split(' ');

        if (values.Length == 0) {
            return null;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode root = new TreeNode(int.Parse(values[0]));
        queue.Enqueue(root);

        int index = 1;
        while (index < values.Length) {
            TreeNode current = queue.Dequeue();

            if (index < values.Length && values[index] != "#") {
                current.left = new TreeNode(int.Parse(values[index]));
                queue.Enqueue(current.left);
            }
            index++;

            if (index < values.Length && values[index] != "#") {
                current.right = new TreeNode(int.Parse(values[index]));
                queue.Enqueue(current.right);
            }
            index++;
        }

        return root;
    }

    static void Main(string[] args) {
        Console.WriteLine("Enter the tree nodes separated by space (use '#' for null nodes):");
        string input = Console.ReadLine();

        TreeNode root = BuildBinaryTree(input);

        Console.Write("Preorder Traversal: ");
        PreOrderTraversal(root);
    }
}
