//leetcode 525. Contiguous Array

public class Solution {
    public int FindMaxLength(int[] nums) {
        Dictionary<int, int> dict = []; //map count to index
        int count = 0;
        int max = 0;

        for(int i=0; i < nums.Length; i++)
        {
            if(nums[i] == 0) count--;
            else count++;

            //when count reaches 0, it means there are equal number of 0 and 1 from beginning, we update max
            if(count == 0)
            {
                max = Math.Max(max, i+1);
            }
            //if the count hasn't been tracked, that means no equal number of 0 and 1, then we track the index
            else if(!dict.ContainsKey(count))
            {
                dict[count] = i;
            }
            //if the count already tracked, that means equal number of 0 and 1, so we update max
            else
            {
                int diff = i - dict[count];
                max = Math.Max(max, diff);
            }
        }

        return max;
    }
}