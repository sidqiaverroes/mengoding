//leetcode 20: Valid Parentheses

public class Solution {
    public bool IsValid(string s) {
        // My original solution
        List<string> list = [];
        
        foreach(var x in s)
        {
            string x2 = x.ToString();
            int n = list.Count-1; // index

            if(x2 == "(" || x2 == "[" || x2 == "{")
            {
                list.Add(x2);
            }
            else
            {
                if(n < 0) return false;

                if(list[n] == "(" && x2 == ")")
                {
                    list.RemoveAt(n);
                    continue;
                }
                else if(list[n] == "[" && x2 == "]")
                {
                    list.RemoveAt(n);
                    continue;
                }
                else if(list[n] == "{" && x2 == "}")
                {
                    list.RemoveAt(n);
                    continue;
                }
                else return false;
            }
        }

        return !list.Any();
    }
}