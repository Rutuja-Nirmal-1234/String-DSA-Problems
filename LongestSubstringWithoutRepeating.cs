// Problem: Longest Substring Without Repeating Characters (Sliding Window)

// Question:
// Write a program to find the length of the longest substring without repeating characters
// in a given string.

// Input:
// - A string containing letters, digits, or symbols

// Output:
// - Length of the longest substring with all unique characters

// Example:
// Input: "abcabcbb"
// Output: 3
// Explanation: The longest substring without repeating characters is "abc"
//
// Input: "bbbbb"
// Output: 1
// Explanation: The longest substring without repeating characters is "b"

// Notes:
// - Use a sliding window approach with two pointers (start and end).
// - Expand the window by moving the end pointer and track characters in a hash set.
// - If a character repeats, shrink the window from the start until no duplicates remain.

// Complexity:
// Time Complexity: O(n) (n = length of string)
// Space Complexity: O(min(n, charset_size)) (to store characters in hash set)

using System;
using System.Collections.Generic;

public class LongestSubstringWithoutRepeating
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int length = LengthOfLongestSubstring(input);
        Console.WriteLine("Length of Longest Substring Without Repeating Characters: " + length);
    }

    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();
        int maxLength = 0, left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
