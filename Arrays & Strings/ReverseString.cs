/*
Write a function that reverses a string. The input string is given as an array of characters char[].

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

You may assume all the characters consist of printable ascii characters.

https://leetcode.com/problems/reverse-string/
 */

public class Solution 
{
    // Iterative
    public void ReverseString(char[] s) 
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            char c = s[left];
            s[left] = s[right];
            s[right] = c;
            
            left++;
            right--;
        }
    }
    // Recursive
    public void ReverseString(char[] s) {
        int len = s.Length - 1;
        if (len <= 1) return;
        
        string lowEnd = s.Substring(0, len / 2);
        string highEnd = s.Substring(len / 2 + 1, len);
        return reverseString(lowEnd) + reverseString(highEnd);
    }
}