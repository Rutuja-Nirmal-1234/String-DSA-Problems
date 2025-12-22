// Problem: Longest Common Prefix
// LeetCode: 14

// Description:
// Given an array of strings, find the longest common prefix string among them.
// If there is no common prefix, return an empty string "".

// Approach:
// 1. Take the first string as the initial prefix.
// 2. Compare character by character with each other string.
// 3. If mismatch or string ends, return prefix up to that point.

// Example:
// Input: ["flower","flow","flight"]
// Output: "fl"

// Time Complexity: O(N * M), where N = number of strings, M = length of the shortest string
// Space Complexity: O(M)

using System;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        string prefix = strs[0];

        for (int i = 0; i < prefix.Length; i++)
        {
            char ch = prefix[i];

            for (int j = 1; j < strs.Length; j++)
            {
              
                if (i >= strs[j].Length)
                    return prefix.Substring(0, i);

                
                if (strs[j][i] != ch)
                    return prefix.Substring(0, i);
            }
        }

        return prefix;
    }
}
