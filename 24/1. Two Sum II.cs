//leetcode 167. Two Sum II - Input Array Is Sorted

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //Two Pointer Approach
        Dictionary<int, int> dict =[];

        int l = 0;
        int r = numbers.Length-1;

        while(l<r)
        {
            if(numbers[l] + numbers[r] == target) break;

            if(numbers[l] + numbers[r] > target)
            {
                r--;
                while(numbers[r+1] == numbers[r]) r--;
            }
            else if(numbers[l] + numbers[r] < target)
            {
                l++;
                while(numbers[l-1] == numbers[l]) l++;
            }
        }

        return [l+1, r+1];
    }

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