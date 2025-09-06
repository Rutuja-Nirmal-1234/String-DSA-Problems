// Problem: Longest Substring With At Most K Distinct Characters (Sliding Window)

// Question:
// Write a program to find the length of the longest substring that contains at most K distinct characters in a given string.

// Input:
// - A string containing letters, digits, or symbols
// - An integer K representing the maximum number of distinct characters allowed

// Output:
// - Length of the longest substring with at most K distinct characters

// Example:
// Input: s = "eceba", k = 2
// Output: 3
// Explanation: The longest substring with at most 2 distinct characters is "ece"
//
// Input: s = "aa", k = 1
// Output: 2
// Explanation: The longest substring with at most 1 distinct character is "aa"

// Notes:
// - Use a sliding window approach with two pointers (start and end).
// - Use a dictionary to track the frequency of characters in the current window.
// - Expand the window by moving the end pointer.
// - Shrink the window from start if distinct character count exceeds K.

// Complexity:
// Time Complexity: O(n) (n = length of string)
// Space Complexity: O(min(n, charset_size)) (dictionary stores character frequencies)

using System;
using System.Collections.Generic;

public class LongestSubstringKDistinct
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        Console.Write("Enter value of K: ");
        int k = int.Parse(Console.ReadLine());

        int length = LengthOfLongestSubstringKDistinct(s, k);
        Console.WriteLine("Length of Longest Substring With At Most " + k + " Distinct Characters: " + length);
    }

    public static int LengthOfLongestSubstringKDistinct(string s, int k)
    {
        if (k == 0 || string.IsNullOrEmpty(s))
            return 0;

        Dictionary<char, int> charFrequency = new Dictionary<char, int>();
        int maxLength = 0, start = 0;

        for (int end = 0; end < s.Length; end++)
        {
            char c = s[end];
            if (charFrequency.ContainsKey(c))
                charFrequency[c]++;
            else
                charFrequency[c] = 1;

            while (charFrequency.Count > k)
            {
                char startChar = s[start];
                charFrequency[startChar]--;
                if (charFrequency[startChar] == 0)
                    charFrequency.Remove(startChar);
                start++;
            }

            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}
