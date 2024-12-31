//leetcode 771. Jewels and Stones

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> set = new HashSet<char>(jewels);
        int count = 0;

        foreach(var s in stones)
        {
            if(set.Contains(s)) count++;
        }

        return count;
    }
}