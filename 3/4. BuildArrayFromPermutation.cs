//leet code 1920: Build Array from Permutation

public class Solution {
    public int[] BuildArray(int[] nums) {
        // My original solution
        // List<int> result = [];

        // for(int i=0; i<nums.Length; i++)
        // {
        //     result.Add(nums[nums[i]]);
        // }

        // return result.ToArray();

        // alternate solution
        int n = nums.Length;

        for(int i=0; i<n; i++)
        {
            nums[i] = nums[i] + n * (nums[nums[i]]%n);
        }

        for(int i=0; i<n; i++)
        {
            nums[i] = nums[i]/n;
        }

        return nums;
    }
}