// Problem: First Unique Character in a String
// LeetCode: 387

// Description:
// Given a string s, find the index of the first non-repeating character.
// If it does not exist, return -1.

// Approach:
// 1. Use a Dictionary<char, int> to count frequency of each character.
// 2. Traverse the string again to find the first character with frequency 1.

// Example:
// Input:  "leetcode"
// Output: 0  (character 'l')

// Input:  "loveleetcode"
// Output: 2  (character 'v')

// Time Complexity: O(n)
// Space Complexity: O(1)  (since only 26 lowercase letters)

using System;
using System.Collections.Generic;

public class Program
{
    public static int FirstUniqueChar(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        // Step 1: Count frequency
        foreach (char c in s)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        // Step 2: Find first unique character
        for (int i = 0; i < s.Length; i++)
        {
            if (freq[s[i]] == 1)
                return i;
        }

        return -1;
    }

    public static void Main()
    {
        string s = "leetcode";
        Console.WriteLine(FirstUniqueChar(s));
    }
}
