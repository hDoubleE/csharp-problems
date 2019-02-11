using System;

namespace DataStructures
{
    public class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] arr = { -2, 5, 1, 4, -3, 6, -6, 5, 2, -5 };
            sol.MaxSubArray(arr);
        }
    }


    public sealed class Solution
    {
        public int MaxSubArrayQuadratic(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array is null or empty.");
            }
            // Why does this work and 0 does not...?
            int maxSum = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int curSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    curSum += arr[j];
                    maxSum = Math.Max(curSum, maxSum);
                }
            }
            return maxSum;
        }

        // Long solution.
        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (currentSum + nums[i] > nums[i])
                {
                    currentSum += nums[i];
                }

                else
                {
                    currentSum = nums[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            return maxSum;
        }

        // Refactored solution, Math.Max is faster than previous if/else version.
        public int MaxSubArray2(int[] nums)
        {
            int maxSum = nums[0];
            int curSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                curSum = Math.Max(curSum + nums[i], nums[i]);
                maxSum = Math.Max(curSum, maxSum);
            }
            return maxSum;
        }
    }
}
