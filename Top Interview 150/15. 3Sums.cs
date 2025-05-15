//15. 3Sum
//15 May 2025

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> res = [];

        Array.Sort(nums);

        int start = 0;
        int left;
        int right;

        while(start < nums.Length - 2)
        {
            //skip if the value same
            if(start > 0 && nums[start] == nums[start-1])
            {
                start++;
                continue;
            }

            left = start+1;
            right = nums.Length-1;

            while(left<right)
            {
                //check triplets
                int sum = nums[start] + nums[left] + nums[right];

                if(sum > 0)
                {
                    right--;
                }
                else if(sum < 0)
                {
                    left++;
                }
                else //sum == 0
                {
                    IList<int> triplet = [];
                    triplet.Add(nums[start]);
                    triplet.Add(nums[left]);
                    triplet.Add(nums[right]);

                    res.Add(triplet);

                    while(nums[left] == triplet[1] && left<right) left++;
                    while(nums[right] == triplet[2] && left<right) right--;
                }
            }

            start++;
        }

        return res;
    }
}