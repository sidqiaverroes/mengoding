//1061. Lexicographically Smallest Equivalent String
//5 June 2025

public class Solution {
    private int[] parent = new int[26];
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {
        int n = s1.Length;
        
        for(int i = 0; i < 26; i++) {
            parent[i] = -1;
        }
        for(int i = 0; i < n; i++) {
            Union(s1[i] - 'a', s2[i] - 'a');
        }
        StringBuilder st = new StringBuilder();
        foreach(char ch in baseStr) {
            st.Append((char)(Find(ch - 'a') + 'a'));
        }
        return st.ToString();
    }
    public void Union(int a, int b) {
        //Console.WriteLine($"Union {a}, {b}");
        a = Find(a);
        b = Find(b);
        //Console.WriteLine($"find {a}, {b}");
        if (a != b)
            parent[Math.Max(a, b)] = Math.Min(a, b);
    }
    public int Find(int a) {
        //Console.WriteLine($"Search {a}");
        if (parent[a] == -1) {
            return a;
        }
        int pa = Find(parent[a]);
        //Console.WriteLine($"Found {pa}");
        parent[a] = pa;
        return parent[a];
    }
}