// leetcode 136. Single Number

public class Solution {
    public int SingleNumber(int[] nums) {
        //My initial solution, its not that efficient, it think its O(n log n) bcs of the .Contains and .Remove
        List<int> Candidates = [];

        for(int i=0; i<nums.Length; i++)
        {
            if(Candidates.Contains(nums[i]))
            {
                Candidates.Remove(nums[i]);
            }
            else
            {
                Candidates.Add(nums[i]);
            }
        }

        return Candidates[0];
    }

    public int SingleNumber(int[] nums) {
        // Alternative using bit manipulation and logic XOR (^) operation
        // Intuition: 
        // x ^ 0 = x
        // x ^ x = 0
        // so if the number appear twice it will cancel each other, and the single value remains
        
        int res = 0;

        for(int i=0; i<nums.Length; i++)
        {
            res = res^nums[i];
        }

        return res;
    }
}