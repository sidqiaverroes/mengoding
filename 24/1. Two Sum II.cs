//leetcode 167. Two Sum II - Input Array Is Sorted

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> dict =[];

        for(int i=0; i<numbers.Length; i++)
        {
            int complement = target - numbers[i];
            if(dict.ContainsKey(complement))
            {
                return new int[] {dict[complement]+1, i+1};
            }
            
            if(!dict.ContainsKey(numbers[i]))
            {
                dict.Add(numbers[i], i);
            }
        }

        return [];
    }
}