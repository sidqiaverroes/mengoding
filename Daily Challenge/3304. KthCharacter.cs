//3304. Find the K-th Character in String Game I
//3 July 2025

public class Solution
{
    public char KthCharacter(int k)
    {
        List<int> listofChar = [];
        listofChar.Add(97);

        while (listofChar.Count() < k)
        {
            List<int> buffer = [];
            foreach (var c in listofChar)
            {
                buffer.Add(c + 1);
            }
            listofChar.AddRange(buffer);
        }

        return ((char)listofChar[k - 1]);
    }
}