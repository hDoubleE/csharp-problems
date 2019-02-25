/* You are a product manager and currently leading a team to develop a new product. 
Unfortunately, the latest version of your product fails the quality check. 
Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which will return whether version is bad. 
Implement a function to find the first bad version. You should minimize the number of calls to the API.

https://leetcode.com/problems/first-bad-version/
 */


/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

// Implement Binary Search, where instead of returning mid, increment min by one and return min.
public class Solution : VersionControl 
{
    public int FirstBadVersion(int n) {
        if (n == 0 || n == 1) return n;
        int min = 1;
        int max = n;
        while (min < max)
        {
            int mid = min + (max - min) / 2;
            if (IsBadVersion(mid))
            {
                max = mid;
            }
            else 
            {
                min = mid + 1;
            }
        }
        return min;
    }
    
}