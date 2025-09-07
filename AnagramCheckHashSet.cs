// Problem: Check if Two Strings are Anagrams (Using HashSet)

// Question:
// Write a program to check if two given strings are anagrams of each other.
// Two strings are anagrams if they contain the same characters with the same frequency,
// but possibly in a different order.
//
// This version uses HashSet to compare character sets.

// Input:
// - Two strings (e.g., "listen" and "silent")

// Output:
// - True if the strings are anagrams, False otherwise

// Example:
// Input: str1 = "listen", str2 = "silent"
// Output: True
//
// Input: str1 = "hello", str2 = "world"
// Output: False

// Notes:
// - Remove spaces and convert to lowercase for uniformity.
// - If lengths differ, return false immediately.
// - Use HashSet<char> to store characters of first string and verify against the second string.
// - Limitation: HashSet only checks for distinct characters, not their frequencies.
//   For proper anagram check with duplicate letters, frequency comparison is required.

// Complexity:
// Time Complexity: O(n + m) (n = length of str1, m = length of str2)
// Space Complexity: O(min(n, m)) (for the HashSet)

using System;
using System.Collections.Generic;

public class AnagramCheckHashSet
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine().Replace(" ", "").ToLower();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine().Replace(" ", "").ToLower();

        bool result = AreAnagrams(str1, str2);

        Console.WriteLine(result
            ? "The strings are anagrams."
            : "The strings are NOT anagrams.");
    }

    public static bool AreAnagrams(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        HashSet<char> set1 = new HashSet<char>(s1);
        HashSet<char> set2 = new HashSet<char>(s2);

        return set1.SetEquals(set2);
    }
}
