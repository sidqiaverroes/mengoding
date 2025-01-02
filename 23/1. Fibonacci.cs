//leetcode 509. Fibonacci Number

public class Solution {
    public int Fib(int n) {
        if(n == 0) return 0;
        if(n == 1) return 1;

        return Fib(n-2) + Fib(n-1);
    }

    public int Fib(int n) {
        List<int> list = [];

        for(int i=0; i<=n; i++)
        {
            if(list.Count == 0) list.Add(0);
            else if(list.Count == 1) list.Add(1);
            else
            {
                list.Add(list[i-2] + list[i-1]);
            }
        }

        return list[list.Count-1];
    }

    public int Fib(int n) {
        if(n == 0) return 0;

        int prev = 0;
        int curr = 1;

        for(int i=1; i<n; i++)
        {
            int temp = curr;
            curr += prev;
            prev = temp;
        }

        return curr;
    }

}