//219. Contains Duplicate II
//20 May 2025

public class Solution
{
    //Dictionary approach
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> dict = []; //map nums and last index

        int index = 0;
        foreach (var n in nums)
        {
            if (!dict.ContainsKey(n))
            {
                dict.Add(n, index);
            }
            else
            {
                if ((index - dict[n]) <= k) return true;
                dict[n] = index;
            }

            index++;
        }

        return false;
    }
}