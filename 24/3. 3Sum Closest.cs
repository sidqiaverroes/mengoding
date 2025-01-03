//leetcode 16. 3Sum Closest

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);

        int lowestGap = Int32.MaxValue;
        int res = 0;

        int start = 0, left, right;

        while(start<nums.Length-2)
        {
            left = start+1;
            right = nums.Length-1;

            while(left<right)
            {
                int sum = nums[start] + nums[left] + nums[right];
                int gap = Math.Abs(target-sum);
                if(lowestGap > gap)
                {
                    lowestGap = gap;
                    res = sum;
                }

                if(sum > target) right --;
                else if( sum < target) left++;
                else
                {
                    return sum;
                }
            }

            start++;
        }

        return res;
    }
}