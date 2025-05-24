//2942. Find Words Containing Character
//24 May 2025

public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        IList<int> ans = [];
        int index = 0;
        foreach (var w in words)
        {
            foreach (var y in w)
            {
                if (y == x)
                {
                    ans.Add(index);
                    break;
                }
            }
            index++;
        }

        return ans;
    }
}