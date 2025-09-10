// Problem: Longest Substring Without Repeating Characters (Using Dictionary)

// Question:
// Write a program to find the length of the longest substring 
// without repeating characters in a given string.

// Input:
// - A string (e.g., "abcabcbb")

// Output:
// - An integer representing the length of the longest substring without repeating characters

// Example:
// Input: "abcabcbb"
// Output: 3   ("abc")
//
// Input: "bbbbb"
// Output: 1   ("b")
//
// Input: "pwwkew"
// Output: 3   ("wke")

// Notes:
// - Use a sliding window with two pointers (start, end).
// - Use a Dictionary to store the last index of each character.
// - If a duplicate is found, move the start pointer to the next index after its last occurrence.
// - Update maxLength whenever a larger valid window is found.

// Complexity:
// Time Complexity: O(n) (each character processed once)
// Space Complexity: O(min(n, m)) (where m = character set size)

using System;
using System.Collections.Generic;

public class LongestSubstringDictionary
{
    public static int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> lastIndex = new Dictionary<char, int>();
        int start = 0, maxLength = 0;

        for (int end = 0; end < s.Length; end++)
        {
            if (lastIndex.ContainsKey(s[end]))
            {
                // Jump start pointer to avoid duplicate
                start = Math.Max(start, lastIndex[s[end]] + 1);
            }

            lastIndex[s[end]] = end; // Update last seen index
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }

    public static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        Console.WriteLine("Length of Longest Substring Without Repeating Characters: " + LengthOfLongestSubstring(s));
    }
}
