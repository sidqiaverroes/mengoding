//781. Rabbits in Forest
//20 April 2025

public class Solution {
    public int NumRabbits(int[] answers) {
        Dictionary<int, int> GroupMap = []; //maps the Value with the number of Appearance <val, num>

        foreach(var ans in answers)
        {
            if(!GroupMap.ContainsKey(ans)) GroupMap[ans] = 0;
            GroupMap[ans]++;
        }

        int res = 0;
        foreach(KeyValuePair<int, int> ele in GroupMap)
        {
            if(ele.Key == 0) res+= ele.Value;
            else
            {
                int factor = ele.Key+1;

                int numOfGroup = ele.Value/factor;
                if(ele.Value%factor != 0) numOfGroup++;

                res += factor*numOfGroup;
                
            }
        }

        return res;
    }
}