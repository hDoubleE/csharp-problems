using System;
using System.Collections.Generic;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions solve = new Solutions();
            int[] theArray = { 2, 8, 12, 4, 9, 6 };
            Console.WriteLine(solve.MaxSequence(theArray, 3));
            Console.WriteLine(solve.CheckDupes(theArray));
        }
    }

    public class Solutions
    {
        // MaxSequence: given an array of int and an int indicating the length of subArray.
        // Compute the max sum of a given subArray within the array.
        // The subArray must be consecutive. Example:
        // Given [ 2, 8, 12, 14, 9, 6, 2, 4 ], 3
        // Return 35 the sum of [ 12, 14, 9 ]

        public int MaxSequence(int[] arr, int num)
        {
            if (arr.Length < num)
            {
                return -1;
            }
            int total = 0;
            for (int i = 0; i < num; i++)
            {
                total += arr[i];
            }
            int currentTotal = total;
            for (int i = num; i < arr.Length; i++)
            {
                currentTotal += arr[i] - arr[i - num];
                total = Math.Max(total, currentTotal);
            }
            return total;
        }
        // CheckDupes: Given an array of integers as input, return true if the array contains duplicates.
        // False if none.
        public bool CheckDupes(int[] arr)
        {
            var collection = new Dictionary<int, int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (collection.ContainsKey(arr[i]))
                {
                    collection[arr[i]] += 1;
                }
                else
                {
                    collection.TryAdd(arr[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> kvp in collection)
            {
                
                Console.WriteLine($"Key: {kvp.Key}, Val: {kvp.Value}");
            }
            foreach (int key in collection.Keys)
            {
                if (collection[key] > 1)
                {
                    return true;
                }
            }
            return false;
        }
        // DeleteDupes: Given a string return an int with the minimum number of deletions needed
        // to remove all consecutive duplicate chars. Example:
        // Input: AABABABB
        // Return: 2 [ABABAB]
        public int DeleteDupes(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i+1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}