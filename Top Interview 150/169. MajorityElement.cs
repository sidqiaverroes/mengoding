//169. Majority Element
//24 April 2025

public class Solution {
    public int MajorityElement(int[] nums) {
        //My original Solution
        //This has time complexity of O(n), since there are 2 not nesting loops
        //And has space complexity of O(n) also, because when worst case happens, it uses the 
        //length of nums for KeyValuePair (even though we can assume there always be major 
        //element)
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++)
        {
            if(map.ContainsKey(nums[i])) map[nums[i]]++;
            else map.Add(nums[i], 1);
        }
        
        foreach(KeyValuePair<int, int> m in map)
        {
            if(m.Value > nums.Length/2) return m.Key;
        }
        
        throw new ArgumentException("Majority not found");
        
        //Boyer-Moore Voting Algorithm Solution
        //This has time complexity of O(n), since there is a loop
        //But has space complexity of O(1), since just using 2 variables
        int candidate = 0;
        int count = 0;

        foreach(int num in nums)
        {
            if(count == 0)
            {
                candidate = num;
                count++;
            }
            else if(candidate == num)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        
        //we can add validation here
        count = 0;
        foreach(int num in nums)
        {
            if(num == candidate) count++;
        }

        if(count > nums.Length/2) return candidate;

        throw new ArgumentException("Majority not found");
    }
}