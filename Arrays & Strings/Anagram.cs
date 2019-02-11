// Given two strings s and t , write a function to determine if t is an anagram of s.
// Input: s = "anagram", t = "nagaram"
// Output: true

// Hastable, works, but slower.
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<int, int> ht = new Dictionary<int, int>();
        
        if (s.Length != t.Length) return false;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (ht.ContainsKey(s[i]))
            {
                ht[s[i]] += 1;
            }
            else 
            {
                ht[s[i]] = 1;    
            }
        }
        for (int j = 0; j < t.Length; j++)
        {
            if(!(ht.ContainsKey(t[j])) || ht[t[j]] == 0)
            {
                return false;
            }
            else 
            {
                ht[t[j]]--;
            }
        }
        return true;
    }
}

// Array, faster!
public class Solution {
    public bool IsAnagram(string s, string t) { 
        if (s.Length != t.Length) return false;
        
        int[] counter = new int[26];
        
        for (int i = 0; i < s.Length; i++)
        {
            counter[s[i] - 'a']++;
        }
        
        for (int j = 0; j < t.Length; j++)
        {
            counter[t[j] - 'a']--;
            if (counter[t[j] - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
    }
}