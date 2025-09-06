// Problem: Reverse Each Word in a String Individually (Concise Version)

// Question:
// Reverse each word in a given string individually while keeping the word order intact.

// Input:
// - A string containing one or more words separated by spaces

// Output:
// - A string where each word is reversed but the original order is preserved

// Example:
// Input: "my favorite car is bmw"
// Output: "ym etirovaf rac si wmb"

// Notes:
// - Split the string into words
// - Reverse each word using LINQ
// - Join the reversed words back into a single string

// Complexity:
// Time Complexity: O(n) (n = total number of characters)
// Space Complexity: O(n) (for storing reversed words)

using System;
using System.Linq;

public class ReverseEachWordConcise
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = string.Join(" ", input
            .Split(' ')
            .Select(word => new string(word.Reverse().ToArray()))
        );

        Console.WriteLine("Reversed Words: " + result);
    }
}
