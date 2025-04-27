//3392. Count Subarrays of Length Three With a Condition
//27 April 2025

public class Solution {
    public int CountSubarrays(int[] nums) {
        int count = 0;

        for(int i=0; i<nums.Length-2; i++)
        {
            if((double)nums[i]+(double)nums[i+2] == (double)nums[i+1]/2) count++;
        }
        
        return count;
    }
}