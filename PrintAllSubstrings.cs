// Problem: Print All Substrings of a String

// Question:
// Write a program to print all possible substrings of a given string.

// Input:
// - A string (e.g., "abc")

// Output:
// - All possible substrings of the string
//   Example: "a", "ab", "abc", "b", "bc", "c"

// Example:
// Input: "abc"
// Output:
// a
// ab
// abc
// b
// bc
// c

// Notes:
// - A substring is a contiguous sequence of characters within a string.
// - Use two nested loops:
//   1. Outer loop selects the starting index
//   2. Inner loop selects the ending index
//   3. Print substring from start to end

// Complexity:
// Time Complexity: O(n^2) (where n = length of string)
// Space Complexity: O(1) (excluding output storage)

using System;

public class PrintAllSubstrings
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("All Substrings:");
        PrintSubstrings(input);
    }

    public static void PrintSubstrings(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                Console.WriteLine(s.Substring(i, j - i + 1));
            }
        }
    }
}
