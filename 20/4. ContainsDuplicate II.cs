//leetcode 219. Contains Duplicate II

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=1; j<=k; j++)
            {
                if(i+j<nums.Length && nums[i] == nums[i+j]) return true;
            }
        }

        return false;

        //we can use another approach: dictionary and sliding window, try to use that next
        //this is a go to algortihm "brute force" lol.
    }
}