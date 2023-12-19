/*
Given an array of distinct integers, find length of the longest subarray which contains numbers that can be arranged in a continuous sequence. 

Examples: 
Input:  arr[] = {10, 12, 11};
Output: Length of the longest contiguous subarray is 3

Input:  arr[] = {14, 12, 11, 20};
Output: Length of the longest contiguous subarray is 2

Input:  arr[] = {1, 56, 58, 57, 90, 92, 94, 93, 91, 45};
Output: Length of the longest contiguous subarray is 5
*/
using System;

class Program
{
    static int FindLongestContiguousSubarray(int[] arr)
    {
        int n = arr.Length;
        if (n <= 1)
            return n;

        // Sort the array
        Array.Sort(arr);

        int maxLength = 1;
        int currentLength = 1;

        // Iterate through the sorted array
        for (int i = 1; i < n; i++)
        {
            // Check if the current element is consecutive to the previous one
            if (arr[i] == arr[i - 1] + 1)
            {
                currentLength++;
            }
            else if (arr[i] != arr[i - 1])
            {
                // Reset the current length if the sequence is broken
                currentLength = 1;
            }

            // Update the maximum length
            maxLength = Math.Max(maxLength, currentLength);
        }

        return maxLength;
    }

    static void Main()
    {
        // Example 1
        int[] arr1 = { 10, 12, 11 };
        Console.WriteLine("Input:  {10, 12, 11}");
        Console.WriteLine($"Output: Length of the longest contiguous subarray is {FindLongestContiguousSubarray(arr1)}\n");

        // Example 2
        int[] arr2 = { 14, 12, 11, 20 };
        Console.WriteLine("Input:  {14, 12, 11, 20}");
        Console.WriteLine($"Output: Length of the longest contiguous subarray is {FindLongestContiguousSubarray(arr2)}\n");

        // Example 3
        int[] arr3 = { 1, 56, 58, 57, 90, 92, 94, 93, 91, 45 };
        Console.WriteLine("Input:  {1, 56, 58, 57, 90, 92, 94, 93, 91, 45}");
        Console.WriteLine($"Output: Length of the longest contiguous subarray is {FindLongestContiguousSubarray(arr3)}");
    }
}
