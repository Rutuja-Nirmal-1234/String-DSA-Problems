// LeetCode 392 - Is Subsequence
// https://leetcode.com/problems/is-subsequence/

// Problem:
// Given two strings s and t, return true if s is a subsequence of t.

// Approach: Two Pointers
// - Use pointer i for string s
// - Use pointer j for string t
// - Move j always, move i only when characters match
// - If i reaches end of s, it is a subsequence

// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public bool IsSubsequence(string s, string t) {

        int i = 0;
        int j = 0;

        while (i < s.Length && j < t.Length) {
            if (s[i] == t[j]) {
                i++;
            }
            j++;
        }

        return i == s.Length;
    }
}
