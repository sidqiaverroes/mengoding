//leetcode 27: Remove Element

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        //My original solution
        int l = 0;
        int r = nums.Length-1;
        int index = 0;

        if(nums.Length < 1) return 0;

        if(nums.Length == 1 && nums[0] == val) return 0;

        while(l<=r)
        {
            if(nums[r] != val)
            {
                int temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
                l++;
            }
            else
            {
                r--;
            }
        }

        return l;
    }
}