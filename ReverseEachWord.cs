// Problem: Reverse Each Word in a String Individually

// Question:
// Write a program to reverse each word in a given string individually
// while keeping the word order intact.

// Input:
// - A string containing one or more words separated by spaces
//   (e.g., "my favorite car")

// Output:
// - A string where each word is reversed but the original order is preserved

// Example:
// Input: text = "my favorite car is bmw"
// Output: "ym etirovaf rac si wmb"
//
// Input: text = "hello world"
// Output: "olleh dlrow"

// Notes:
// 1. Split the string by spaces to get individual words.
// 2. Reverse each word separately.
// 3. Join the reversed words back with spaces.

// Complexity:
// Time Complexity: O(n) (where n = total number of characters in the string)
// Space Complexity: O(n) (for storing reversed words)

using System;

public class ReverseEachWord
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }

        string result = string.Join(" ", words);
        Console.WriteLine("Reversed Words: " + result);
    }
}
