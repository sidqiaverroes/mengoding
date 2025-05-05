//205. Isomorphic Strings
//5 May 2025

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> map = [];
        HashSet<char> set = [];

        for(int i=0; i<s.Length; i++)
        {
            if(!map.ContainsKey(s[i]))
            {
                if(set.Contains(t[i])) return false;

                map.Add(s[i], t[i]);
                set.Add(t[i]);
            }
            else
            {
                if(map[s[i]] != t[i]) return false;
            }
        }

        return true;
    }
}