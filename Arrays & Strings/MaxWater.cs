// Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). 
//n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
//Find two lines, which together with x-axis forms a container, such that the container contains the most water.
// Note: You may not slant the container and n is at least 2.

/*
Uses two pointers and global max (dynamic programming).

 */
public class Solution {
    public int MaxArea(int[] height) {

        int start = 0;
        int end = height.Length - 1;
        
        int maxVolume = 0; 
        int currVolume = 0;
        int minHeight = 0;
        
        while (start < end)
        {
            minHeight = Math.Min(height[start], height[end]);
            currVolume = minHeight * (end - start);
            
            if (maxVolume < currVolume)
            {
                maxVolume = currVolume;
            }
            
            if (height[start] <= height[end])
            {
                start++;
            }
            else
            {
                end--;
            }
        }
        return maxVolume;
    }
}