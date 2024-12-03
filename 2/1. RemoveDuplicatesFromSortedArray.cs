//leetcode 26: Remove Duplicates From Sorted Array

//My solution
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int currentNum = nums[0];
        int index = 1;

        for(int i=1; i < nums.Length; i++)
        {
            if(nums[i] != currentNum)
            {
                currentNum = nums[i];
                nums[index] = nums[i];
                index++;
            }
        }
        
        return index;
    }
}