//leetcode 1470: Shuffle the Array

public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        //My origin solution, so simple, downside: space complexity > O(1)
        List<int> res = [];
        
        for(int i=0; i<n; i++)
        {
            res.Add(nums[i]);
            res.Add(nums[i+n]);
        }

        return res.ToArray();

        //There is another approach that does this in place
        // by using a trick to store old value and new value in the same value
        // ------- x = a + b * mod
        // a is old value, b is new value, mod is a big enough integer such as a,b<mod
        // to restore the value:
        // ------- a = x % mod
        // ------- b = x / mod

    }
}