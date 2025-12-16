// Problem: Count Frequency of Characters in a String

// Description:
// Given a string, count how many times each character appears in the string.

// Approach:
// Use a Dictionary<char, int> to store the frequency of each character.
// Traverse the string and update the count for every character.

// Example:
// Input:  str = "rutuja"
// Output:
// r -> 1
// u -> 2
// t -> 1
// j -> 1
// a -> 1

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string str = "rutuja";

        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char ch in str)
        {
            if (freq.ContainsKey(ch))
                freq[ch]++;
            else
                freq[ch] = 1;
        }

        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}
