// 2563. Count the Number of Fair Pairs
// 19 April 2025

public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);
        long count = 0;

        for (int i = 0; i < nums.Length - 1; i++) {
            int left = LowerBound(nums, i + 1, nums.Length - 1, lower - nums[i]);
            int right = UpperBound(nums, i + 1, nums.Length - 1, upper - nums[i]);

            count += (right - left + 1);
        }

        return count;
    }

    private int LowerBound(int[] nums, int left, int right, int target) {
        int res = right + 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] >= target) {
                res = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return res;
    }

    private int UpperBound(int[] nums, int left, int right, int target) {
        int res = left - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] <= target) {
                res = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return res;
    }
}
