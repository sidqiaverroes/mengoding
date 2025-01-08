//leetcode 189. Rotate Array

public class Solution {
    public void Rotate(int[] nums, int k) {
        int mod = k % nums.Length;

        if(mod == 0 || nums.Length == 1) return;
        
        List<int> numsList = new List<int>(nums);

        int i = 0;

        int index1 = nums.Length - mod;

        while(i < nums.Length)
        {
            nums[i] = numsList[index1];
            
            if(index1 == nums.Length-1) index1 = -1;

            index1++;

            i++;
        }
    }
}