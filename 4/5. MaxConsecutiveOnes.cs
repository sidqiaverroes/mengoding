//leetcode 485: Max Consecutive Ones

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        //My original solution
        int maxCount = 0;
        int count = 0;

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                count++;
            }
            else
            {
                count = 0;
            }

            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }
}