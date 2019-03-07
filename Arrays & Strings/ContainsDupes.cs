// Given an array of integers, find if the array contains any duplicates.
// Your function should return true if any value appears at least twice in 
// the array, and it should return false if every element is distinct.
// Leetcode, hash approach or sort.
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> ht = new HashSet<int>();
        foreach (int num in nums)
        {
            if (ht.Contains(num))
            {
                return true;
            }
            else
            {
                ht.Add(num);
            }
        }
        return false;
    }
    // Using sort first.
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i-1])
            {
                return true;
            }
        }
        return false;
    }
}
