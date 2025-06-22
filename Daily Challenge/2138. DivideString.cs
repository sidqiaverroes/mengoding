//2138. Divide a String Into Groups of Size k
//23 June 2025

public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        int len = s.Length / k;
        int remainder = s.Length % k;
        string str = s;

        if (remainder != 0)
        {
            len += 1;

            int gap = k - remainder;

            while (gap > 0)
            {
                str += fill.ToString();
                gap--;
            }
        }

        string[] res = new string[len];

        string subs = "";
        int resIndex = 0;
        int index = 0;
        foreach (var c in str)
        {
            subs = subs + c.ToString();

            if ((index + 1) % k == 0)
            {
                res[resIndex] = subs;
                subs = "";
                resIndex++;
            }

            index++;
        }

        return res;
    }
}