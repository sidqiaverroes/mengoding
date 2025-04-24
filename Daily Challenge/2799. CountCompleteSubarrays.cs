//2799. Count Complete Subarrays in an Array
//24 April 2025

public class Solution {
    public int CountCompleteSubarrays(int[] nums) {
        int left = 0, right = 0;
        int distinctCount = CountDistinctValues(nums);
        int res = 0;

        Dictionary<int, int> CurrDistinct = [];

        while(right<nums.Length && left<nums.Length)
        {
            while(right<nums.Length && CurrDistinct.Count != distinctCount)
            {
                int n = nums[right];
                if(!CurrDistinct.ContainsKey(n)) CurrDistinct.Add(n, 0);
                CurrDistinct[n]++;

                right++;
            }

            while(left<nums.Length && CurrDistinct.Count == distinctCount)
            {
                res += nums.Length - (right-1);

                int n = nums[left];
                if(CurrDistinct[n] != 0) CurrDistinct[n]--;
                if(CurrDistinct[n] == 0) CurrDistinct.Remove(n);

                left++;
            }
        }

        return res;
        
    }

    private int CountDistinctValues(int[] nums)
    {
        HashSet<int> set = [];

        foreach(var n in nums)
        {
            set.Add(n);
        }

        return set.Count;
    }


}