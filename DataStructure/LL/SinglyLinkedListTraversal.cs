/*
This is an to practice traversing a linked list. Given a pointer to the head node of a linked list, print each node's data element, one per line. If the head pointer is null (indicating the list is empty), there is nothing to print.

Function Description

Complete the printLinkedList function in the editor below.

printLinkedList has the following parameter(s):

SinglyLinkedListNode head: a reference to the head of the list
Print

For each node, print its data value on a new line (console.log in Javascript).
Input Format

The first line of input contains n, the number of elements in the linked list.
The next  lines contain one element each, the data values for each node.

Note: Do not read any input from stdin/console. Complete the printLinkedList function in the editor below.
Sample Input

2
16
13
Sample Output

16
13
*/


using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    // Complete the printLinkedList function below.
    static void printLinkedList(SinglyLinkedListNode head) {
        do{
            Console.WriteLine(head.data);
            head = head.next;
        }
        while (head != null);
    }

    static void Main(string[] args) {
        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < llistCount; i++) {
            int llistItem = Convert.ToInt32(Console.ReadLine());
            llist.InsertNode(llistItem);
        }

        printLinkedList(llist.head);
    }
}
