//leetcode 324. Wiggle Sort II

public class Solution 
{
    public void WiggleSort(int[] nums) 
    {
        Array.Sort(nums);

        int mid = (nums.Length+1)/2 - 1;
        int last = nums.Length-1;

        int[] nums2 = new int[nums.Length];
        Array.Copy(nums, 0, nums2 , 0, nums.Length);

        for(int i=0; i<nums.Length; i++)
        {
            if(i%2==0)
            {
                nums[i] = nums2[mid];
                mid--;
            }
            else
            {
                nums[i] = nums2[last];
                last--;
            }
        }

    }
}