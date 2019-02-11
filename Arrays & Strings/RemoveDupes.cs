// Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
// Leetcode
// Given nums = [1,1,2]
// Your function should return length = 2, with the first two elements of nums being 1 and 2, output: [1, 2] 
// Given nums = [0,0,1,1,1,2,2,3,3,4]
// our function should return length = 5, elements of nums being modified to [0, 1, 2, 3, 4]
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        int i = 0;
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[i] != nums[j]) 
            {
                i++;
                nums[i] = nums[j];
            }
        }
        return i+1;
    }
}