//leetcode 80: Remove Duplicates from Sorted Array II

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        //My origin solution
        // int count = 0;
        // int index = 0;

        // for(int i=0; i<nums.Length; i++)
        // {
        //     if(nums[i] == x)
        //     {
        //         count++;
        //         nums[index] = x;
        //     }
        //     else
        //     {
        //         count=1;
        //         x = nums[i];
        //         nums[index] = nums[i];
        //     }

        //     if(count < 3)
        //     {
        //         index++;
        //     }
        // }

        // return index;

        //Alternative solution
        if(nums.Length <=2) return nums.Length;
        
        int k = 2;

        for(int i=2; i<nums.Length; i++)
        {
            if(nums[i] != nums[k-2])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}