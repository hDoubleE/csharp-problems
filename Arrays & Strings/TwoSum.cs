// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// Map value to index. 

// https://leetcode.com/problems/two-sum/


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> ht = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int comp = target - nums[i];
            if (ht.ContainsKey(comp))
            {
                return new[] { ht[comp], i };
            }
            ht[nums[i]] = i;
        }
        return null;
    }
}