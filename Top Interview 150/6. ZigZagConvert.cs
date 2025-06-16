//6. Zig Zag Conversion
//16 June 2025

public class Solution
{
    public string Convert(string s, int numRows)
    {
        Dictionary<int, string> zigzag = [];

        int row = 1;
        bool IsBounce = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (!zigzag.ContainsKey(row))
            {
                zigzag.Add(row, s[i].ToString());
            }
            else
            {
                zigzag[row] = zigzag[row] + s[i].ToString();
            }

            row = IsBounce ? row - 1 : row + 1;

            if (row == 1) IsBounce = false;
            else if (row == numRows) IsBounce = true;
        }

        string res = "";
        foreach (var kvp in zigzag)
        {
            res = res + kvp.Value;
        }

        return res;
    }
}