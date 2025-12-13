// Problem: Reverse a String

// Description:
// Write a function that reverses a string in-place.
// The input is given as an array of characters.

// Approach:
// Use two pointers:
// - One starting from the beginning
// - One starting from the end
// Swap characters and move pointers inward until they meet.

// Example:
// Input:  s = ['h', 'e', 'l', 'l', 'o']
// Output: ['o', 'l', 'l', 'e', 'h']

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class Program
{
    public static void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Swap characters
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
    }

    public static void Main()
    {
        char[] s = {'h', 'e', 'l', 'l', 'o'};

        ReverseString(s);

        Console.WriteLine(string.Join(",", s));
    }
}
