//leetcode: Move Zeroes Solution

public class Solution {
    public void MoveZeroes(int[] nums) {
        //My original solution
        int n = nums.Length;
        int count = 0;
        for(int i = 0; i<n; i++)
        {
            if(nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = 0;
                nums[count] = temp;
                count++;
            }
        }
    }
}