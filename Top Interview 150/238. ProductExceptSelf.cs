//238. Product of Array Except Self
//8 May 2025

public class Solution {
    
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n]; // Initializes all elements to 0 by default
        Array.Fill(result, 1);     // Fills the array with 1

        int currentPrefix = 1;
        int currentSuffix = 1;
        for(int i=0; i<n; i++)
        {
            result[i] = result[i] * currentPrefix;
            result[n-1-i] = result[n-1-i] * currentSuffix;

            currentPrefix = currentPrefix * nums[i];
            currentSuffix = currentSuffix * nums[n-1-i];
        }

        return result;
    }
}