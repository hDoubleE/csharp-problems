using Stytem;

/*
Given an array of integers nums sorted in ascending order,
find the starting and ending position of a given target value.
Your algorithm's runtime complexity must be in the order of O(log n).
If the target is not found in the array, return [-1, -1].

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]
 */


public class Solution {
    public int[] SearchRange(int[] nums, int target) 
    {
        // Declare results.
        int[] results = {-1, -1};
        
        // Search for leftmost index.
        int leftResult = BinarySearch(nums, target, SearchType.FIRST);
        
        // If target value not found, return results.
        if (leftResult == -1)
        {
            return results;
        }
        
        // If target value found, assign to results.
        results[0] = leftResult;
        
        // Search for rightmost index and assign to results.
        results[1] = BinarySearch(nums, target, SearchType.LAST);
        
        // Return.
        return results;
    }
    
    // Declare enum to track search type.
    private enum SearchType
    {
        FIRST,
        LAST
    }
    
    // Modified Binary search, to include two search types.
    private int BinarySearch(int[] arr, int target, SearchType searchType)
    {
        // Declare start and end.
        int start = 0;
        int end = arr.Length - 1;
        
        while (start <= end)
        {
            // Prevent overflow: don't use (start + end) / 2.
            int mid = start + (end - start) / 2;
            
            // If target value found, branch into search first or search last.
            if (arr[mid] == target)
            {
                //Search for first occurence of target value.
                if (searchType == SearchType.FIRST)
                {
                    // If still in bounds and previous equal current value.
                    // Move search index back one.
                    if (isInBounds(arr, mid - 1) && arr[mid - 1] == arr[mid])
                    {
                        end = mid - 1;
                    }
                    else 
                    {
                        return mid;
                    }
                }
                
                // Search for last occurence of target value. 
                else if (searchType == SearchType.LAST)
                {
                    // still in bounds and next value equals current value.
                    // Move search index up one.
                    if (isInBounds(arr, mid + 1) && arr[mid + 1] == arr[mid])
                    {
                        start = mid + 1;
                    }
                    else 
                    {
                        return mid;
                    }
                }

            }
            
            // Otherwise target value not yet found, continue regular binary search.
            else if (arr[mid] < target)
            {
                start = mid + 1;
            }
            else 
            {
                end = mid - 1;
            }
        }
        return -1;
    } 
    
    // Verify next value is still in bounds to prevent overflow.
    private bool isInBounds(int[] arr, int index)
    {
        return index >= 0 && index <= arr.Length - 1;
    }
    // Alternate version
    public int[] SearchRange(int[] arr, int target) 
    {
        int[] results = {-1, -1};
        
        if(arr == null || arr.Length == 0)
            return results;
        
        int start = 0;
        int end = arr.Length - 1;
        
        // Search left.
        while (start < end)
        {
            int mid = start + (end - start) / 2;
            
            if (arr[mid] < target)
                start = mid + 1;
            else 
                end = mid;
        }
        
        if (arr[start] == target)
            results[0] = start;
        
        end = arr.Length - 1;
        
        // Search right.
        while (start < end)
        {
            int mid = (start + (end - start) / 2) + 1;
            if (arr[mid] > target)
                end = mid - 1;
            else 
                start = mid;
        }
        
        if (arr[start] == target)
            results[1] = start;
        
        return results;
       
    }
}

// [5, 7, 7, 8, 8, 10]
//        ^  m      ^