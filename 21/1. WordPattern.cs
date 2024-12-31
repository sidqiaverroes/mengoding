//leetcode 290. Word Pattern

public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(" ");
        Dictionary<char, string> map = [];

        if(words.Length != pattern.Length) return false;

        int index = 0;
        foreach(var p in pattern)
        {
            if(!map.ContainsKey(p))
            {
                //Check if the word alredy mapped
                foreach(var m in map)
                {
                    if(m.Value == words[index]) return false;
                }
                map.Add(p, words[index]);
            }
            else
            {
                if(map[p] != words[index]) return false;
            }
            index++;
        }

        return true;
    }
}