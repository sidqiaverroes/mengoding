//leetcode 217. Contains Duplicate

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

        if(nums.Length == set.Count) return false;

        return true;
    }
}