//3443. Maximum Manhattan Distance After K Changes
//20 June 2025

public class Solution
{
    public int MaxDistance(string s, int k)
    {
        int n = 0, s_ = 0, e = 0, w = 0;
        int maxDist = 0;

        foreach (char ch in s)
        {
            if (ch == 'N') n++;
            else if (ch == 'S') s_++;
            else if (ch == 'E') e++;
            else if (ch == 'W') w++;

            int k1 = k;

            // NS imbalance
            int NS = Math.Abs(n - s_);
            int minNS = Math.Min(n, s_);
            int usedNS = Math.Min(minNS, k1);
            NS += usedNS * 2;
            k1 -= usedNS;

            // EW imbalance
            int EW = Math.Abs(e - w);
            int minEW = Math.Min(e, w);
            int usedEW = Math.Min(minEW, k1);
            EW += usedEW * 2;
            k1 -= usedEW;

            maxDist = Math.Max(maxDist, NS + EW);
        }

        return maxDist;
    }
}