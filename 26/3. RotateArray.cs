//leetcode 189. Rotate Array

public class Solution {
    public void Rotate(int[] nums, int k) {
        int mod = k % nums.Length;

        if(mod == 0 || nums.Length == 1) return;
        
        List<int> numsList = new List<int>(nums);

        int l = 0;
        int r = nums.Length-1;

        int index1 = nums.Length - mod;
        int index2 = index1 - 1;

        while(l <= r)
        {
            nums[l] = numsList[index1];
            nums[r] = numsList[index2];
            
            if(index1 == nums.Length-1) index1 = -1;
            if(index2 == 0) index2 = nums.Length;

            index1++;
            index2--;

            l++;
            r--;
        }
    }
}