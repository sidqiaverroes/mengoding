//leetcode 581. Shortest Unsorted Continuous Subarray

public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        if(nums.Length <= 1) return 0;

        int l = 0;
        int r = nums.Length-1;

        while(l<nums.Length-1 && nums[l+1] >= nums[l])
        {
            l++;
        }

        while(r > 0 && nums[r-1] <= nums[r])
        {
            r--;
        }

        if(l == nums.Length-1 && r == 0) return 0;

        int min = nums[l];
        int max = nums[r];
        for(int i=l; i<=r; i++)
        {
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
        }
        
        int leftIndex = l;
        int rightIndex = r;

        while(leftIndex >= 0 && min < nums[leftIndex]) leftIndex--;
        while(rightIndex <= nums.Length-1 && max > nums[rightIndex]) rightIndex++;

        rightIndex--;
        leftIndex++;
        int diff = rightIndex - leftIndex;

        return diff+1;
    }
}