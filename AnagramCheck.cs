// Problem: Check if Two Strings are Anagrams

// Question:
// Write a program to check if two given strings are anagrams of each other.
// Two strings are anagrams if they contain the same characters with the same frequency,
// but possibly in a different order.

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
// 1. Remove spaces and convert both strings to lowercase for uniformity.
// 2. Count the frequency of each character and compare.
// 3. If all character counts match, the strings are anagrams.

// Complexity:
// Time Complexity: O(n + m) (n = length of first string, m = length of second string)
// Space Complexity: O(1) (considering character set is fixed, e.g., 26 letters)


using System;

public class AnagramCheck
{
    static bool AreAnagrams(string str1, string str2)
    {
        // Remove spaces and convert to lowercase
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        if (str1.Length != str2.Length)
            return false;

        int[] count = new int[26]; // For letters a-z

        for (int i = 0; i < str1.Length; i++)
        {
            count[str1[i] - 'a']++;
            count[str2[i] - 'a']--;
        }

        // If all counts are zero, strings are anagrams
        foreach (int c in count)
        {
            if (c != 0)
                return false;
        }

        return true;
    }

    public static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        if (AreAnagrams(s1, s2))
            Console.WriteLine("Strings are anagrams.");
        else
            Console.WriteLine("Strings are NOT anagrams.");
    }
}
