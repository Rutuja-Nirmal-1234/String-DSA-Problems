// Problem: Reverse Words in a String
// LeetCode: 151

// Description:
// Given an input string s, reverse the order of the words.
// A word is defined as a sequence of non-space characters.
// The returned string should have only a single space separating words
// and no leading or trailing spaces.

// Approach (Manual Traversal from Right):
// 1. Start from the end of the string.
// 2. Skip extra spaces.
// 3. Identify each word by moving left.
// 4. Append the word to the result.
// 5. Continue until the beginning of the string.

// Example:
// Input:  "  hello   world  "
// Output: "world hello"

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Text;

public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder result = new StringBuilder();
        int i = s.Length - 1;

        while (i >= 0)
        {
            // 1️⃣ Skip extra spaces
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            if (i < 0)
                break;

            // 2️⃣ Mark end of word
            int j = i;

            // 3️⃣ Move left till start of word
            while (j >= 0 && s[j] != ' ')
            {
                j--;
            }

            // 4️⃣ Append the word
            result.Append(
                s.Substring(j + 1, i - j)
            );

            result.Append(' ');

            // 5️⃣ Move to next word
            i = j - 1;
        }

        return result.ToString().Trim();
    }
}
