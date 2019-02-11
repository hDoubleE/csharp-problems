using System;
using System.Collections.Generic;

namespace Palindrome
{
    public class Program
    {
        public static void Main()
        {
            string s1 = "radar";
            string s2 = "deeeed";
            string s3 = "notapal";
            string s4 = String.Empty;

            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();
            char[] c3 = s3.ToCharArray();
            char[] c4 = s4.ToCharArray();

            Console.WriteLine(Solution.isPalindromeArray(c1));
            Console.WriteLine(Solution.isPalindromeArray(c2));
            Console.WriteLine(Solution.isPalindromeArray(c3));
            Console.WriteLine(Solution.isPalindromeArray(c4));
        }
    }

    public class Solution
    {
        public static bool isPalindromeArray(char[] arr)
        {
            if (arr.Length == 0)
            {
                return false;
            }

            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                if (arr[start] == arr[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}