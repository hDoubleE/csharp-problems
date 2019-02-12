using System;
using System.Collections.Generic;

namespace Problems
{
    public class Program
    {
        static void Main()
        {
        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> results = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    int start = i + 1;
                    int end = nums.Length - 1;
                    while (start < end)
                    {
                        if (nums[i] + nums[start] + nums[end] == 0)
                        {
                            results.Add(new List<int>() { nums[i], nums[start], nums[end] });
                        }
                        while (start < end && nums[start] == nums[start + 1])
                        {
                            start++;
                        }
                        while (start < end && nums[end] == nums[end - 1])
                            end--;
                        {
                            start++;
                            end--;
                        }
                    }
                }
            }
            return results;
        }
    }
}