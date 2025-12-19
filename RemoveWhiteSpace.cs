// Problem: Remove Whitespaces from a String

// Description:
// Given a string s, remove all whitespace characters
// and return the resulting string.

// Approach (StringBuilder):
// 1. Traverse the string character by character.
// 2. Append only non-space characters to StringBuilder.
// 3. Convert StringBuilder to string and return.

// Example:
// Input:  "Hello RDP"
// Output: "HelloRDP"

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Text;

public class HelloWorld
{
    public static string RemoveWhiteSpace(string s)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                result.Append(s[i]);
            }
        }

        return result.ToString();
    }

    public static void Main(string[] args)
    {
        string input = "Hello RDP";
        Console.Write(RemoveWhiteSpace(input));
    }
}
