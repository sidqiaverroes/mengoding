//leetcode 171. Excel Sheet Column Number

public class Solution {
    public int TitleToNumber(string columnTitle) {
        int len = columnTitle.Length-1;
        int res = 0;

        for(int i=0; i<len+1; i++)
        {
            res += (int)Math.Pow(26, i) * (columnTitle[len-i] - '@');
        }

        return res;
    }

    //A = 1             -> 26^0 * 1
    //AA = 27           -> 26^0 + 26^1
    //AAA = 703         -> 26^0 + 26^1 + 26^2
    //AAAA = 18279      -> 26^0 + 26^1 + 26^2 + 26^3
    //AAAAA = 475255    -> 26^0 + 26^1 + 26^2 + 26^3 + 26^4

    //B = 2             -> (26^0)*2
    //BA = 53           -> (26^0)*1 + (26^1)*2
    //BAA = 1379        -> (26^0)*1 + (26^1)*1 + (26^2)*2
    //BAAA = 35855      -> (26^0)*1 + (26^1)*1 + (26^2)*1 + (26^3)*2
    //BAAAA = 932231    -> 26^0 + 26^1 + 26^2 + 26^3 + 26^4
}