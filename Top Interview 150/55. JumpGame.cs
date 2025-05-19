//55. Jump Game
//19 May 2025

public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length;
        int currentGoalIndex = n-1;

        for(int i=n-2; i>=0; i--)
        {
            if(i+nums[i] >= currentGoalIndex) currentGoalIndex = i;
        }

        return currentGoalIndex == 0;
    }
}