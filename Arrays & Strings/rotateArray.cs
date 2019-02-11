public class Solution {

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
// Two-pass approach, temp array get garbage collected.
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

// In-place approach.
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