//838. Push Dominoes
//2 May 2025

public class Solution {
    public string PushDominoes(string dominoes)
    {
        int n = dominoes.Length;
        char[] result = dominoes.ToCharArray();
        int i = 0;

        int left = 0;

        while (left < n)
        {
            if (result[left] != '.')
            {
                left++;
                continue;
            }

            int right = left;
            while (right < n && result[right] == '.') right++;

            char leftChar = left > 0 ? result[left - 1] : '.';
            char rightChar = right < n ? result[right] : '.';

            if (leftChar == 'R' && rightChar == 'L')
            {
                int len = right - left;
                for (int k = 0; k < len / 2; k++)
                {
                    result[left + k] = 'R';
                    result[right - k - 1] = 'L';
                }
                // middle remains '.' if len is odd
            }
            else if (leftChar == 'R')
            {
                for (int k = left; k < right; k++) result[k] = 'R';
            }
            else if (rightChar == 'L')
            {
                for (int k = left; k < right; k++) result[k] = 'L';
            }

            left = right;
        }

        return new string(result);
    }


}