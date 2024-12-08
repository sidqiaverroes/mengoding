//leetcode 496: Next Greater Element I

public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        //My original solution, cannot accomplish timecomplexity O(n + m)
        List<int> arr = [];
        Dictionary<int, int> map = [];

        int n = nums1.Length;
        int m = nums2.Length;

        for(int i=0; i<m; i++)
        {
            for(int j=i; j<m; j++)
            {
                if(nums2[i] < nums2[j])
                {
                    map.Add(nums2[i], nums2[j]);
                    break;
                }
            }
        }

        for(int i =0; i<n; i++)
        {
            if(map.ContainsKey(nums1[i]))
            {
                arr.Add(map[nums1[i]]);
            }
            else
            {
                arr.Add(-1);
            }
        }

        return arr.ToArray();
    }
}