// Problem: Longest Substring Without Repeating Characters (Using HashSet)

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
// - Use a sliding window with two pointers (left, right).
// - Use a HashSet to store the current window’s characters.
// - If a duplicate is found, shrink the window from the left until it's removed.
// - Update maxLength whenever a larger valid window is found.

// Complexity:
// Time Complexity: O(n) (each character visited at most twice: once added, once removed)
// Space Complexity: O(min(n, m)) (where m = character set size, e.g., 26 for lowercase letters)

using System;
using System.Collections.Generic;

public class LongestSubstringHashSet
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> window = new HashSet<char>();
        int left = 0, maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            // If duplicate found → shrink from the left
            while (window.Contains(s[right]))
            {
                window.Remove(s[left]);
                left++;
            }

            window.Add(s[right]); // Add current character
            maxLength = Math.Max(maxLength, right - left + 1);
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
