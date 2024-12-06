//leetcode 905: Sort Array By Parity

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        //My original solution
        List<int> arr = [];

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i]%2 == 0)
            {
                arr.Add(nums[i]);
            }
        }

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i]%2 != 0)
            {
                arr.Add(nums[i]);
            }
        }

        return arr.ToArray();
    }
}