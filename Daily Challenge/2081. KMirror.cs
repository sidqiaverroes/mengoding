//2081. Sum of k-Mirror Numbers
//24 June 2025

public class Solution
{
    public long KMirror(int k, int n)
    {
        long sum = 0;
        for (long len = 1; n > 0; len *= 10)
        {
            for (long i = len; n > 0 && i < len * 10; i++)
            {
                long p = createPalindrome(i, true);
                if (isPalindrome(p, k)) { sum += p; n--; }
            }
            for (long i = len; n > 0 && i < len * 10; i++)
            {
                long p = createPalindrome(i, false);
                if (isPalindrome(p, k)) { sum += p; n--; }
            }
        }
        return sum;
    }

    long createPalindrome(long num, bool odd)
    {
        long x = num;
        if (odd) x /= 10;
        while (x > 0)
        {
            num = num * 10 + x % 10;
            x /= 10;
        }
        return num;
    }

    bool isPalindrome(long num, int basis)
    {
        StringBuilder sb = new StringBuilder();
        while (num > 0)
        {
            sb.Append((char)(num % basis + '0'));
            num /= basis;
        }
        string s = sb.ToString();
        int i = 0, j = s.Length - 1;
        while (i < j) if (s[i++] != s[j--]) return false;
        return true;
    }
}