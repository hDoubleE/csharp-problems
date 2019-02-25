// Given a string, find the first non-repeating character in it and return it's index. 
// If it doesn't exist, return -1.
// https://leetcode.com/problems/first-unique-character-in-a-string/
public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> ht = new Dictionary<char, int>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (!ht.ContainsKey(s[i]))
            {
                ht[s[i]] = 1;
            }
            else
            {
                ht[s[i]] += 1;
            }
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            if (ht[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}

// Using array, faster!
public class Solution {
    public int FirstUniqChar(string s) {
        int[] arr = new int[128];
        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i]]++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (arr[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}