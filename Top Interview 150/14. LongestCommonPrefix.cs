//14. Longest Common Prefix
//28 April 2025

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int index = strs[0].Length;

        for(int i=0; i<strs.Length-1;i++)
        {
            if(strs[i] == "") return "";
            int j = 0;
            while(j<strs[i].Length && j<strs[i+1].Length)
            {
                if(strs[i][j] == strs[i+1][j])
                {
                    j++;
                }
                else
                {
                    break;
                }
            }
            index = Math.Min(index, j);
        }

        return strs[0].Substring(0, index);
    }
}