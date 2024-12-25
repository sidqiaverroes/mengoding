//leetcode 67. Add Binary

public class Solution {
    public string AddBinary(string a, string b) {
        List<char> res = [];

        char[] charA = a.Length > b.Length ? a.ToCharArray() : b.ToCharArray(); // longer
        char[] charB = a.Length <= b.Length ? a.ToCharArray() : b.ToCharArray(); // shorter

        Array.Reverse(charA);
        Array.Reverse(charB);

        int len = charB.Length;

        bool IsCarry = false;

        for(int i=0; i<len; i++)
        {
            if(charA[i] == '1' && charB[i] == '1')
            {
                if(IsCarry)
                {
                    res.Add('1');
                }
                else
                {
                    res.Add('0');
                }
                IsCarry = true;
            }
            else if(charA[i] == '0')
            {
                if(IsCarry)
                {
                    if(charB[i] == '0')
                    {
                        res.Add('1');
                        IsCarry = false;
                    }
                    else
                    {
                        res.Add('0');
                    }
                }
                else
                {
                    char B = charB[i];
                    res.Add(B);
                }
            }
            else if(charB[i] == '0')
            {
                if(IsCarry)
                {
                    if(charA[i] == '0')
                    {
                        res.Add('1');
                        IsCarry = false;
                    }
                    else
                    {
                        res.Add('0');
                    }
                }
                else
                {
                    char A = charA[i];
                    res.Add(A);
                }
            }
        }

        int Index = res.Count;
        for(int i=Index; i<charA.Length; i++)
        {
            if(IsCarry)
            {
                if(charA[i] == '0')
                {
                    res.Add('1');
                    IsCarry = false;
                }
                else
                {
                    res.Add('0');
                }
            }
            else
            {
                char A = charA[i];
                res.Add(A);
            }
        }

        if(IsCarry)
        {
            res.Add('1');
        }
        
        res.Reverse();
        return String.Join("", res);
    }
    
    //0 = 0
    //1 = 1
    //10 = 2
    //11 = 3
    //100 = 4
    //101 = 5
    //110 = 6
    //111 = 7
    //1000 = 8
    //1001 = 9
    //1010 = 10
    //1011 = 11
    //1100 = 12
    //1101 = 13
    //1110 = 14
    //1111 = 15
    //10000 = 16
    //10001 = 17

    // 2 + 3 = 10 + 11 = 101 = 5
    // 3 + 7 = 11 + 111 = 1010 = 10
    // 4 + 13 = 100 + 1101 = 10001 = 17

}