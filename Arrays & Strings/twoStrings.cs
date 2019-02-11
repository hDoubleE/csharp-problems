using System;
using System.Collections.Generic;

// Given two strings, determine if they share a common substring. A substring may be as small as one character.
// For example, the words "a", "and", "art" share the common substring . The words "be" and "cat" do not share a substring.

namespace Problem
{
    class Solution
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Solution.containsSubstring("be", "cat"));
        }

        private static string containsSubstring(string s1, string s2)
        {
            if (s1 == string.Empty || s2 == string.Empty)
            {
                return "NO";
            }

            HashSet<char> set1 = new HashSet<char>();

            foreach (char c in s1)
            {
                set1.Add(c);
            }

            foreach (char c in s2)
            {
                if (set1.Contains(c))
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}
