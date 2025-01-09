//leetcode 560. Subarray Sum Equals K

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        int sum = 0;
        Dictionary<int,int> map = []; //map sum to index

        for(int i=0; i<nums.Length; i++)
        {
            sum += nums[i];

            if(sum == k) count++;

            int diff = sum-k;

            if(map.ContainsKey(diff))
            {
                count += map[diff];
            }

            if(!map.ContainsKey(sum))
            {
                map[sum] = 1;
            }
            else
            {
                map[sum]++;
            }
        }

        return count;
    }
}