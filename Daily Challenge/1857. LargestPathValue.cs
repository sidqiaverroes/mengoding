//1857. Largest Color Value in a Directed Graph
//26 May 2025

public class Solution {
    public int LargestPathValue(string colors, int[][] edges) {
        int n = colors.Length;
        List<int>[] adj = new List<int>[n];
        for (int i = 0; i < n; i++) adj[i] = new List<int>();
        foreach (var e in edges) adj[e[0]].Add(e[1]);

        int[][] count = new int[n][];
        for (int i = 0; i < n; i++) count[i] = new int[26];
        int[] vis = new int[n];

        int Dfs(int node) {
            if (vis[node] == 1) return int.MaxValue;
            if (vis[node] == 2) return count[node].Max();
            vis[node] = 1;
            foreach (var next in adj[node]) {
                if (Dfs(next) == int.MaxValue) return int.MaxValue;
                for (int i = 0; i < 26; i++)
                    count[node][i] = Math.Max(count[node][i], count[next][i]);
            }
            count[node][colors[node] - 'a']++;
            vis[node] = 2;
            return count[node].Max();
        }

        int ans = 0;
        for (int i = 0; i < n; i++) {
            int val = Dfs(i);
            if (val == int.MaxValue) return -1;
            ans = Math.Max(ans, val);
        }
        return ans;
    }
}