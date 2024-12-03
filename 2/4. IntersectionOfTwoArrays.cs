//leetcode 349: Intersection of Two Arrays

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        //My origin solution
        // int n = nums1.Length;
        // int m = nums2.Length;
        // List<int> dups = [];
        
        // for(int i=0; i<n; i++)
        // {
        //     for(int j=0; j<m; j++)
        //     {
        //         int x = nums1[i];
        //         if(nums2[j] == x && !dups.Contains(x))
        //         {
        //             dups.Add(x);
        //         }
        //     }
        // }

        // int k = dups.Count();
        // int[] result = new int[k];
        // for(int i =0; i<k; i++)
        // {
        //     result[i] = dups[i];
        // }

        // return result;

        //Another approach
        HashSet<int> map = new(nums1);
        HashSet<int> ans = new();
        foreach (int num in nums2)
        {
            if (map.Contains(num))
            {
                ans.Add(num);
            }                
        }
        return ans.ToArray();
    }
}