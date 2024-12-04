//leetcode 1480: Running Sum of 1d Array

public class Solution {
    public int[] RunningSum(int[] nums) {
        //My original solution
        //comment: meh, not efficient
        // int[] result = new int[nums.Length];
        
        // for(int i=0; i<nums.Length; i++)
        // {
        //     int sum = 0;
        //     for(int j=0; j<i+1; j++)
        //     {
        //         sum += nums[j];
        //     }
        //     result[i] = sum;
        // }

        // return result;

        //Another approach
        for(int i=1; i<nums.Length; i++)
        {
            nums[i] = nums[i] + nums[i-1];
        }

        return nums;
    }
}