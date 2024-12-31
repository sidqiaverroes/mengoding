//leetcode 1207. Unique Number of Occurrences

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> dict = [];
        HashSet<int> set = [];

        foreach(var a in arr)
        {
            if(dict.ContainsKey(a))
            {
                dict[a]++;
            }
            else
            {
                dict.Add(a, 1);
            }
        }

        foreach(KeyValuePair<int,int> d in dict)
        {
            if(set.Contains(d.Value)) return false;
            set.Add(d.Value);
        }

        return true;
    }
}