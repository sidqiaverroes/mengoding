//2176. Count Equal and Divisible Pairs in an Array
//17 April 2025

public class Solution {
    public int CountPairs(int[] nums, int k) {

        int pairCount = 0;

        for(int i=0; i<nums.Length; i++)
        {
            for(int j=i+1; j<nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    if(i*j%k == 0) pairCount++;
                }
            }
        }

        return pairCount;
    }
}