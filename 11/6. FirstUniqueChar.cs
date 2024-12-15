//leetcode 387. First Unique Character in a String

public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> map = [];

        for(int i=0; i<s.Length; i++)
        {
            if(map.ContainsKey(s[i]) && map[s[i]] > 0)
            {
                map[s[i]] = -map[s[i]];
            }
            else if(!map.ContainsKey(s[i]))
            {
                map.Add(s[i], i+1);
            }
        }

        for(int i=0; i<s.Length; i++)
        {
            if(map[s[i]] > 0) return i;
        }

        return -1;
    }
}