//leetcode: Merge Sorted Array Solution

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //My Original Solution
        if(n == 0)
        {
            return;
        }
        else if(m == 0)
        {
            for(int i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
            return;
        }
        else
        {
            int index = 0;
            for(int i = 0; i < m+n; i++)
            {
                if(i >= m)
                {
                    nums1[i] = nums2[index];
                    index++;
                }
                for(int j = index; j < n; j++)
                {
                    if(nums1[i] > nums2[j])
                    {
                        int temp = nums1[i];
                        nums1[i] = nums2[j];
                        nums2[j] = temp;
                    }
                }
            }
        }
    }
}