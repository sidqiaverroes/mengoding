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

    }

    //Dictionary approach
    public bool ContainsNearbyDuplicate2(int[] nums, int k) {
        Dictionary<int, int> dict = []; //map nums and last index
        
        int index = 0;
        foreach(var n in nums)
        {
            if(!dict.ContainsKey(n))
            {
                dict.Add(n, index);
            }
            else
            {
                if((index - dict[n]) <= k) return true;
                dict[n] = index;
            }

            index++;
        }

        return false;
    }

    //Sliding window approach
    public bool ContainsNearbyDuplicate3(int[] nums, int k) {
        HashSet<int> set = []; //map nums and last index
        
        int index = 0;
        foreach(var n in nums)
        {
            if(set.Contains(n))
            {
                return true;
            }

            set.Add(n);

            if(set.Count > k)
            {
                set.Remove(nums[index-k]);
            }

            index++;
        }

        return false;
    }
}