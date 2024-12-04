//leetcode 414: Third Maximum Number

public class Solution {
    public int ThirdMax(int[] nums) {
        //My origin solution, so complex :(
        SortedSet<int> set = new(nums);
        List<int> ans = [];

        foreach(var s in set)
        {
            if(ans.Count == 0)
            {
                ans.Add(s);
            }
            else if(s > ans[ans.Count-1])
            {
                ans.Add(s);
            }
            Console.WriteLine(ans[ans.Count-1]);
        }

        if(ans.Count<3) return ans[ans.Count-1];
        else return ans[ans.Count-3];
    }
}