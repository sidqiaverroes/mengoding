//27. Remove Element
//22 April 2025

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int l = 0, r = nums.Length-1;

        while(l<=r)
        {
            while(l<nums.Length && nums[l] != val) l++;
            while(r>=0 && nums[r] == val) r--;
            if(l>=r) break;
            int temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;
        }

        return l;
    }
}