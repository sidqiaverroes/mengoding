//228. Summary Ranges
//31 May 2025

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> res = new();

        int n = nums.Length;
        if (n == 0) return res;

        int start = nums[0];

        for (int i = 1; i <= n; i++) {
            if (i == n || nums[i] != nums[i - 1] + 1) {
                if (start == nums[i - 1])
                    res.Add(start.ToString());
                else
                    res.Add($"{start}->{nums[i - 1]}");

                if (i < n) start = nums[i];
            }
        }

        return res;
    }
}