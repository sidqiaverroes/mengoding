// leetcode 383. Ransom Note

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(ransomNote.Length > magazine.Length) return false;

        Dictionary<char, int> dict = [];
        
        foreach(var m in magazine)
        {
            if(dict.ContainsKey(m))
            {
                dict[m]++;
            }
            else
            {
                dict.Add(m, 1);
            }
        }

        foreach(var rn in ransomNote)
        {
            if(!dict.ContainsKey(rn)) return false;
            else
            {
                if(dict[rn] <= 0) return false;
                dict[rn]--;
            }
        }

        return true;
    }
}