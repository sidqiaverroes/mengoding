//leetcode 1004. Max Consecutive Ones III

public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int maxLength = 0;
        int lIndex = 0, rIndex = 0;

        while(rIndex < nums.Length)
        {
            if(k > 0)
            {
                if(nums[rIndex] == 0)
                {
                    k--;
                }
                rIndex++;
            }
            else if(k == 0)
            {  
                if(nums[rIndex] == 0)
                {
                    maxLength = Math.Max(maxLength, rIndex-lIndex);
                    if(nums[lIndex] != 0) while(nums[lIndex] == 1) lIndex++;
                    lIndex++;
                    rIndex++;
                }
                else
                {
                    rIndex++;
                }
            }
        }

        maxLength = Math.Max(maxLength, rIndex-lIndex);

        return maxLength;
    }
}