// LeetCode 541 - Reverse String II
// https://leetcode.com/problems/reverse-string-ii/

// Problem:
// Given a string s and an integer k, reverse the first k characters
// for every 2k characters counting from the start of the string.
// If there are fewer than k characters left, reverse all of them.
// If there are between k and 2k characters, reverse the first k characters
// and leave the rest as original.

// Approach:
// Convert string to character array.
// Traverse the array in steps of 2k.
// Reverse characters from index `start` to `start + k - 1`.

// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public string ReverseStr(string s, int k) {
        char[] arr = s.ToCharArray();

        for (int start = 0; start < arr.Length; start += 2 * k) {
            int left = start;
            int right = Math.Min(start + k - 1, arr.Length - 1);

            while (left < right) {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        return new string(arr);
    }
}
