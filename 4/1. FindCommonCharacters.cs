//leetcode 1002: Find Common Characters

public class Solution {
    public IList<string> CommonChars(string[] words) {
        //My original solution
        //Surely its not efficient in Time Complexity, i assume its O(N^2)
        List<string> temp = [];
        List<string> ans = [];

        foreach(var w in words[0])
        {
            ans.Add(w.ToString());
        }

        for(int i=1; i<words.Length; i++)
        {
            foreach(var x in words[i])
            {
                if(ans.Contains(x.ToString()))
                {
                    temp.Add(x.ToString());
                    ans.Remove(x.ToString());
                }
            }

            ans.Clear();
            foreach(var t in temp)
            {
                ans.Add(t.ToString());
            }
            temp.Clear();
        }

        return ans;
    }
}