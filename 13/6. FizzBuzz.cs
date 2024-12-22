//leetcode 412. Fizz Buzz

public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> res = [];
        for(int i=1; i<=n; i++)
        {
            if(i%3 == 0 && i%5 ==0)
            {
                res.Add("FizzBuzz");
            }
            else if(i%3 == 0)
            {
                res.Add("Fizz");
            }
            else if(i%5 == 0)
            {
                res.Add("Buzz");
            }
            else
            {
                res.Add(i.ToString());
            }
        }

        return res;
    }
}