//49. Group Anagrams
//2 June 2025

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> AnagramIndices = [];
        
        for(int i=0; i<strs.Length; i++)
        {
            char[] chars;
            chars = strs[i].ToCharArray();
            Array.Sort(chars);

            string key = string.Join("", chars);

            if(!AnagramIndices.ContainsKey(key)) AnagramIndices.Add(key, new List<string>());
            AnagramIndices[key].Add(strs[i]);
        }

        IList<IList<string>> res = [];
        foreach(var kvp in AnagramIndices)
        {
            res.Add(kvp.Value);
        }

        return res;
    }
}