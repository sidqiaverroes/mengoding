//392. Is Subsequence
//30 April 2025

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0) return true;
        
        int i = 0;
        int j = 0;

        while(j<t.Length)
        {
            if(i >= s.Length) break;

            if(s[i] == t[j])
            {
                i++;
            }
            j++;
        }

        return i == s.Length;
    }
}