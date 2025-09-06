// Problem: Longest Substring Without Repeating Characters (Optimized Sliding Window)

// Question:
// Find the length of the longest substring without repeating characters using an optimized approach.

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
// - Use a sliding window with a dictionary to store the last seen index of each character.
// - If a repeating character is found, move the start pointer to the index after its last occurrence.

// Complexity:
// Time Complexity: O(n) (n = length of string)
// Space Complexity: O(min(n, charset_size)) (dictionary stores character positions)

using System;
using System.Collections.Generic;

public class LongestSubstringOptimized
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
        Dictionary<char, int> lastIndex = new Dictionary<char, int>();
        int maxLength = 0, start = 0;

        for (int end = 0; end < s.Length; end++)
        {
            if (lastIndex.ContainsKey(s[end]))
            {
                start = Math.Max(start, lastIndex[s[end]] + 1);
            }

            lastIndex[s[end]] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}
