//leetcode 448: Find all numbers disappeared in array

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        //My original solution
        // int n = nums.Length;
        // IList<int> result = new List<int>();
        
        // for(int i=1; i<n+1; i++)
        // {
        //     result.Add(i);
        // }

        // for(int i=1; i<n+1; i++)
        // {
        //     if(nums.Contains(i))
        //     {
        //         result.Remove(i);
        //     }
        // }

        // return result;

        //Another approach
        int n = nums.Length;
        IList<int> result = new List<int>();
        for(int i=0; i< n; i++)
        {
            int index = Math.Abs(nums[i])-1;
            if(nums[index] > 0)
            {
                nums[index] = -nums[index];
            }
        }

        for(int i=0; i< n; i++)
        {
            if(nums[i]>0) result.Add(i+1);
        }

        return result;
    }
}