// 38. Count and Say
// 18 April 2025

public class Solution {
    public string CountAndSay(int n) {
        string res = "1";

        for(int i=1; i<n; i++)
        {
            var list = StringToList(res);
            res = ListToString(list);
        }

        return res;
    }

    private List<int[]> StringToList(string s)
    {
        List<int[]> result = [];

        char curr = s[0];
        int count = 0;

        foreach(var c in s)
        {
            if(c != curr)
            {
                int num = curr - '0';
                int[] pair = {num, count};
                result.Add(pair);

                curr = c;
                count = 1;
            }
            else
            {
                count++;
            }
        }
        int num2 = curr - '0';
        int[] pair2 = {num2, count};
        result.Add(pair2);

        return result;
    }

    private string ListToString(List<int[]> list)
    {
        string result = "";

        foreach(var l in list)
        {
            result = result + l[1].ToString() + l[0].ToString();
        }

        return result;
    }
}