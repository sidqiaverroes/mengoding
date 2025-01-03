//leetcode 665. Non-decreasing Array

public class Solution {
    public bool CheckPossibility(int[] nums) {
        int prevHighest = 0;
        int count = 0;

        for(int i=1; i<nums.Length; i++)
        {
            if(nums[i] < nums[i-1]) //decreasing
            {
                if(i<nums.Length-1) //when it is not the last item
                {
                    if(nums[i+1] < nums[i-1]) // when the decreasing also happen next
                    {
                        // when the last highest number > next item or
                        // when the last highest number > current item
                        // that means we need to change more than 1 values, then return false
                        if(prevHighest > nums[i+1] || prevHighest > nums[i]) return false;
                    }
                }
                count++;
            }
            prevHighest = Math.Max(prevHighest, nums[i-1]);
        }

        return count <= 1;
    }
}