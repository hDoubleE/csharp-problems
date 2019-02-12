// Given a string, find the length of the longest substring without repeating characters.
// Example abcabcbb, return 3 "abc" is max substring with no duplicates.

// Time complexity : O(2n) = O(n). 
// Space complexity (HashSet): O(min(m, n)).
// In the worst case each character will be visited twice by i and j.

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int result = 0;
        int i = 0;
        int j = 0;
        HashSet<char> hs = new HashSet<char>();

        while (i < n && j < n)
        {
            // try to extend the range [i, j]
            if (!hs.Contains(s[j]))
            {
                hs.Add(s[j]);
                j++;
                result = Math.Max(result, j - i);
            }
            else
            {
                hs.Remove(s[i]);
                i++;
            }
        }
        return result;
    }
    // Time complexity : O(n). Index j will iterate n times.
    // Space complexity (HashMap): O(min(m, n)). Same as the previous approach.
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int result = 0;
        // Table contains char : index pairs.
        Dictionary<char, int> ht = new Dictionary<char, int>();
        // try to extend the range [i, j]
        for (int j = 0, i = 0; j < n; j++)
        {
            if (ht.ContainsKey(s[j]))
            {
                i = Math.Max(ht[s[j]], i);
            }
            // Update index in table.
            ht[s[j]] = j + 1; 
            result = Math.Max(result, j - i + 1);
        }
        return result;
    }
    // Time complexity : O(n). Index j will iterate n times.
    // Space complexity (table): O(m).
    // int[26] for Letters 'a' - 'z' or 'A' - 'Z'
    // int[128] for ASCII
    // int[256] for Extended ASCII

    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int result = 0;
        // Array holds index values at char element.
        int[] index = new int[128];
        for (int j = 0, i = 0; j < n; j++)
        {
            i = Math.Max(index[s[j]], i);
            result = Math.Max(result,j - i + 1);
            index[s[j]] = j + 1;
        }
        return result;
    }
}

