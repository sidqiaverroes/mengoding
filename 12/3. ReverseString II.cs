//leetcode 541. Reverse String II

public class Solution {
    public string ReverseStr(string s, int k) {
        if(s.Length == 0 || k < 2) return s;
        if(s.Length <= k) return ReverseString(s);

        List<string> arr = [];
        //i    :    0     |     1    |      2     |     3
        //k = 2: 0 1 (2 3), 4 5 (6 7), 8 9 (10 11), 12 13 (14 15)
        //k = 3: 1 2 3, 7 8 9, 13 14 15

        // i*2*k s.d ((i+1)*2*k)-1
        for(int i=0; i<s.Length/(2*k)+1; i++)
        {
            int length = 2*k;
            int start = i*length;

            string subStr = "";
            string reversedSubStr = "";

            if(start+length-1 < s.Length) //if the end index inside the array
            {
                subStr = s.Substring(start, length);
            }
            else
            {
                subStr = s.Substring(start);
            }

            if(subStr.Length > k)
            {
                reversedSubStr = ReverseString(subStr.Substring(0, k)) + subStr.Substring(k);
            }
            else
            {
                reversedSubStr = ReverseString(subStr.Substring(0));
            }


            arr.Add(reversedSubStr);
        }


        string res = String.Join("", arr.ToArray());

        return res;
    }

    private string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();

        int l = 0;
        int r = charArray.Length-1;

        while(l<r)
        {
            char temp = charArray[l];
            charArray[l] = charArray[r];
            charArray[r] = temp;

            l++;
            r--;
        }

        string res = new string(charArray);

        return res;
    }
}