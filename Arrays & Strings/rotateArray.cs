public class Solution {
// Given an array, rotate the array to the right by k steps, where k is non-negative.
// Input: [1,2,3,4,5,6,7] and k = 3
// Output: [5,6,7,1,2,3,4]
// Explanation:
// rotate 1 steps to the right: [7,1,2,3,4,5,6]
// rotate 2 steps to the right: [6,7,1,2,3,4,5]
// rotate 3 steps to the right: [5,6,7,1,2,3,4]

// https://leetcode.com/problems/rotate-array/


    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] result = Solution.rotateArrayLeft(a, 2);

        Console.WriteLine(string.Join(" ", result));
    }
    public static int[] rotateArrayLeft(int[] origArr, int k)
    {
        int len = origArr.Length;
        int numberOfRotations = k;
        int[] newArr = new int[len];

        for (int i = 0; i < len; i++)
        {
            int newIndex = (i + numberOfRotations) % len;
            newArr[i] = origArr[newIndex];
        }
        return newArr;
    }
}
// Two-pass approach, with temporary buffer array.
// O(n+k)
public class Solution {
    public void Rotate(int[] nums, int k) 
    {
        int[] tempArr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            tempArr[(i + k) % nums.Length] = nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = tempArr[i];
        }
    }
}

// In-place approach. O(n).
public class Solution {
    public void Rotate(int[] nums, int k) {
        // where array size is less than order num 
        k %= nums.Length;
        // first reverse whole array
        Reverse(nums, 0, nums.Length - 1);
        // reverse front half, before k
        Reverse(nums, 0, k - 1);
        // reverse second half, k to end.
        Reverse(nums, k, nums.Length - 1);
        
    }
    public static void Reverse(int[] nums, int start, int end)
    {
      // swaps elements.
        while (start <= end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}