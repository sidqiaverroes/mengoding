//26. Remove Duplicates from Sorted Array
//23 April 2025

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