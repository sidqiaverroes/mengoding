//594. Longest Harmonious Subsequence
//30 June 2025

public class Solution
{
    public int FindLHS(int[] nums)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (freqMap.ContainsKey(num))
            {
                freqMap[num]++;
            }
            else
            {
                freqMap[num] = 1;
            }
        }

        int maxLength = 0;

        foreach (int key in freqMap.Keys)
        {
            if (freqMap.ContainsKey(key + 1))
            {
                int length = freqMap[key] + freqMap[key + 1];
                maxLength = Math.Max(maxLength, length);
            }
        }

        return maxLength;
    }
}