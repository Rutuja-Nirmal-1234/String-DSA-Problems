// Problem: Valid Palindrome

// Description:
// Given a string s, determine if it is a palindrome,
// considering only alphanumeric characters and ignoring cases.

// Approach:
// 1. Build a cleaned string containing only lowercase letters and digits.
// 2. Use two pointers (left & right) to compare characters from both ends.

// Example:
// Input:  s = "A man, a plan, a canal: Panama"
// Output: true

// Input:  s = "race a car"
// Output: false

// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public bool IsPalindrome(string s) {
        List<char> input = new List<char>();
        foreach(char ch in s){
            if(char.IsLetterOrDigit(ch)){
                input.Add(char.ToLower(ch));
            }
        }
        
        int left =0;
        int right = input.Count-1;
        while(left<right){

            if(input[left] != input[right]){
                return false;
            }
            left++;
            right--;
        }

        return true;
        

      
    }
}
