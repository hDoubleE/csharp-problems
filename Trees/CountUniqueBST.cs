using System;

/* 
 * Given n, how many structurally unique BST's (binary search trees) that store values 1 ... n?
 * Given n = 3, there are a total of 5 unique BST's.
 * In combinatorial mathematics, the Catalan numbers form a sequence of numbers that occur in counting problems, often recursively.
 * 1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796...
 * The outer loop sets the next value at index position i in sequence. 
 * The inner loop computes and resets j to index position 1 at each iteration of i, summing the next Catalan value on its way.
 * Runtime O(n^2) with O(n) extra space.
 */

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumTrees(10));
            // Returns: 16796
        }
        public static int NumTrees(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    arr[i] += arr[j - 1] * arr[i - j];
                }
            }
            return arr[n];
        }
    }
}