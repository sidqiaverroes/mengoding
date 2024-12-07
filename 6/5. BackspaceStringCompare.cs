//leetcode 844: Backspace String Compare

public class Solution {
    public bool BackspaceCompare(string s, string t) {
        //My original solution
        List<char> sArr = [];
        List<char> tArr = [];

        foreach(var x in s)
        {
            if(x == '#' && sArr.Any())
            {
                sArr.RemoveAt(sArr.Count-1);
            }
            else if(x != '#')
            {
                sArr.Add(x);
            }
        }

        foreach(var x in t)
        {
            if(x == '#' && tArr.Any())
            {
                tArr.RemoveAt(tArr.Count-1);
            }
            else if(x != '#')
            {
                tArr.Add(x);
            }
        }

        if(sArr.Count != tArr.Count) return false;

        for(int i=0; i<sArr.Count; i++)
        {
            if(sArr[i] != tArr[i]) return false;
        }

        return true;
        
    }
}