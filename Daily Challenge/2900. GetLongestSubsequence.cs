//2900. Longest Unequal Adjacent Groups Subsequence I
//15 May 2025

public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        List<string> ans = [];

        ans.Add(words[0]);
        for(int i=1; i<groups.Length; i++)
        {
            if(groups[i] != groups[i-1]) ans.Add(words[i]);
        }

        return ans;
    }
}