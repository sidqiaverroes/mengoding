//242. Valid Anagram
//11 May 2025

public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = [];

        for(int i=0; i<s.Length; i++)
        {
            if(map.ContainsKey(s[i]))
            {
                map[s[i]] += 1;
            }
            else
            {
                map.Add(s[i], 1);
            }
        }

        for(int i=0; i<t.Length; i++)
        {
            if(map.ContainsKey(t[i]) && map[t[i]] > 0)
            {
                map[t[i]] -= 1;
            }
            else
            {
                return false;
            }
        }

        foreach(KeyValuePair<char,int> kvp in map)
        {
            if(kvp.Value > 0) return false;
        }

        return true;
    }
}