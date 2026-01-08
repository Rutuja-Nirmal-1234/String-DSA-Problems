// LeetCode 49 - Group Anagrams
// https://leetcode.com/problems/group-anagrams/

// Problem:
// Given an array of strings strs, group the anagrams together.
// You can return the answer in any order.

// Approach:
// HashMap + Sorting
// Sort each string to generate a key.
// All anagrams will have the same sorted key.
// Group strings using this key.

// Time Complexity: O(n * k log k)
// n = number of strings, k = max length of a string
// Space Complexity: O(n * k)

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            string key = new string(arr);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }

        return new List<IList<string>>(map.Values);
    }
}
