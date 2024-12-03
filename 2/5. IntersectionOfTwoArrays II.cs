//leetcode 350: Intersection of Two Arrays II
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        int m = nums2.Length;

        int index1 = 0;
        int index2 = 0;

        List<int> res = [];

        while(index2 < m)
        {
            while(index1 < n)
            {
                if(index2==m) break;
                if(nums1[index1] == nums2[index2])
                {
                    res.Add(nums1[index1]);
                    nums1[index1] = -1;
                    index1 = 0;
                    index2++;
                }
                else
                {
                    index1++;
                }
            }
            index1 = 0;
            index2++;
        }
        return res.ToArray();
    }
}