// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
// Note: For the purpose of this problem, we define empty string as valid palindrome.

// Input: "A man, a plan, a canal: Panama"
// Output: true

public class Solution {
    public bool IsPalindrome(string s) {
        
        int start = 0;
        int end = s.Length - 1;                             
        
        while (start < end)
        {
            // If whitespace or NOT letter, skip.
            if (!char.IsLetterOrDigit(s[start])) start++;
            else if (!char.IsLetterOrDigit(s[end])) end--;
            // Call helper method, if two letters are equal, move pointers.
            else if (AreEqual(s[start], s[end]))
            {
                start++;
                end--;
            }
            // Otherwise, don't match return false.
            else return false;
        }
        return true;
    }
    // Checks if two letters are equal case insensitive.
    private bool AreEqual(char left, char right)
    {
        if (left == right)
        {
            return true;
        }
        if (char.IsLetter(left) && char.IsLetter(right))
        {
            return char.ToLower(left) == char.ToLower(right);
        }
        return false;
    }
}