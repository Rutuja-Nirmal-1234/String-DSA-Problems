// Problem: Find the First Non-Repeating Character in a String

// Question:
// Write a program to find the first character in a string 
// that does not repeat (appears only once).

// Input:
// - A string (e.g., "swiss")

// Output:
// - First non-repeating character, or a message if none exists

// Example:
// Input: "swiss"
// Output: First non-repeating character: w
//
// Input: "aabbcc"
// Output: No non-repeating character found

// Notes:
// Use a frequency dictionary to count occurrences of each character,
// then iterate the string again to find the first with count == 1.

// Complexity:
// Time Complexity: O(n)   (two passes over string)
// Space Complexity: O(1)  (since only 256 ASCII chars possible)

using System;
using System.Collections.Generic;

public class FirstNonRepeatingChar
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Dictionary<char, int> freq = new Dictionary<char, int>();

        // Count frequencies
        foreach (char c in input)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        // Find first non-repeating character
        char? result = null;
        foreach (char c in input)
        {
            if (freq[c] == 1)
            {
                result = c;
                break;
            }
        }

        if (result.HasValue)
            Console.WriteLine("First non-repeating character: " + result);
        else
            Console.WriteLine("No non-repeating character found");
    }
}
