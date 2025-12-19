// Problem: Count Vowels and Consonants

// Description:
// Given a string s, count the number of vowels and consonants.
// Vowels are: a, e, i, o, u (both lowercase and uppercase).
// Ignore non-alphabetic characters.

// Approach:
// 1. Traverse each character in the string.
// 2. Check if the character is a letter.
// 3. If it is a vowel → increment vowel count.
// 4. Else → increment consonant count.

// Example:
// Input: "Hello World"
// Output:
// Vowels = 3
// Consonants = 7

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;
using System.Collections.Generic;

public class Solution
{
    public static void CountVowelsAndConsonants(string s)
    {
        int vowelsCount = 0;
        int consonantsCount = 0;

        HashSet<char> vowels = new HashSet<char>
        {
            'a','e','i','o','u',
            'A','E','I','O','U'
        };

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                if (vowels.Contains(c))
                    vowelsCount++;
                else
                    consonantsCount++;
            }
        }

        Console.WriteLine("Vowels: " + vowelsCount);
        Console.WriteLine("Consonants: " + consonantsCount);
    }

    public static void Main()
    {
        string s = "Hello World";
        CountVowelsAndConsonants(s);
    }
}
