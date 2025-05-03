//1007. Minimum Domino Rotations For Equal Row
//3 May 2025

public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int n = tops.Length;
        
        int modus = tops[0];
        int possibleTop = tops[0];
        int possibleBottom = bottoms[0];

        //find the modus
        for(int i=1; i<n; i++)
        {
            bool matchTop = tops[i] == possibleTop || tops[i] == possibleBottom;
            bool matchBottom = bottoms[i] == possibleTop || bottoms[i] == possibleBottom;

            if(matchTop && !matchBottom)
            {
                modus = tops[i];
                break;
            } 
            else if(matchBottom && !matchTop)
            {
                modus = bottoms[i];
                break;
            }
            else if(!matchTop && !matchBottom)
            {
                return -1;
            }
            else if(tops[i] == bottoms[i] && (matchTop || matchBottom))
            {
                modus = tops[i];
                break;
            }
        }

        int topCount = 0;
        int bottomCount = 0;

        //counting
        for(int i=0; i<n; i++)
        {
            if(tops[i] != modus && bottoms[i] != modus) return -1;

            if(tops[i] == modus) topCount++;
            if(bottoms[i] == modus) bottomCount++;
        }

        return Math.Min(n-topCount, n-bottomCount);
    }
}