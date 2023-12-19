using System;
using System.Collections.Generic;

class Solution
{
    public bool IsPalindrome(string s)
    {
        //Console.WriteLine("str = " + s);
        int n = s.Length;
        if (n == 1)
            return true;
        int i = 0, j = n - 1;

        while (i < j)
        {
            if (s[i] != s[j])
                return false;
            i++;
            j--;
        }
        return true;
    }

    public void Partition(List<List<string>> res, string s,
                        int idx, List<string> curr)
    {
        // If we reach the end of the string, add the current list to the result.
        if (idx == s.Length)
        {
            res.Add(new List<string>(curr));
            return;
        }

        // Stores the current substring.
        string t = string.Empty;
        for (int i = idx; i < s.Length; i++)
        {

            t += s[i];

            // Check whether the string is a palindrome.
            if (IsPalindrome(t))
            {
                // Add the string to the current list.
                curr.Add(t);

                // Recursive call for the remaining string.
                Partition(res, s, i + 1, curr);

                // Remove the string from the current list.
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }

    public static void Main(string[] args)
    {
        Solution ob = new();

        // Stores all the partitions
        List<List<string>> res = new List<List<string>>();
        string s = "Hello";

        // Starting index of the string
        int idx = 0;

        // Current list
        List<string> curr = new List<string>();

        ob.Partition(res, s, idx, curr);

        foreach (var v in res)
        {
            foreach (var it in v)
            {
                Console.Write(it + "   ");
            }
            Console.WriteLine("===");
        }
    }
}
