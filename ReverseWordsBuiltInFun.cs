// Problem: Reverse Words in a String
// LeetCode: 151

// Description:
// Given a string s, reverse the order of the words.
// A word is defined as a sequence of non-space characters.
// The returned string should have only one space between words
// and no leading or trailing spaces.

// Approach (Using Built-in Methods):
// 1. Split the string by spaces and remove empty entries.
// 2. Reverse the array of words.
// 3. Join the words with a single space.

// Example:
// Input:  "  hello   world  "
// Output: "world hello"

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;

public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
