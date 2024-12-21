//leetcode 58. Length of Last Word

public class Solution {
    public int LengthOfLastWord(string s) {
        string[] array = s.Split(" ");
        List<string> filtered = [];

        foreach(var a in array)
        {
            if(!string.IsNullOrEmpty(a))
            {
                filtered.Add(a);
            }
        }

        int i = filtered.Count;
        int result = filtered[i-1].Length;
        return result;
    }
}