//2845. Count of Interesting Subarrays
//25 April 2025

public class Solution {
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k) {
        int count = 0;
        long result = 0;

        Dictionary<int, int> mapModCount = [];
        mapModCount.Add(0, 1);

        foreach(var num in nums)
        {
            if(num % modulo == k) count++;

            int target = (count + modulo - k) % modulo;
            if (mapModCount.TryGetValue(target, out int val)) result += val;

            int mod = count % modulo;
            mapModCount[mod] = mapModCount.GetValueOrDefault(mod, 0) + 1;
        }

        return result;
    }
}