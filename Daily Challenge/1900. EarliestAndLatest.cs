//1900. The Earliest and Latest Rounds Where Players Compete
//12 July 2025

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private Dictionary<string, (int, int)> memo = new Dictionary<string, (int, int)>();

    public int[] EarliestAndLatest(int n, int firstPlayer, int secondPlayer)
    {
        var players = Enumerable.Range(1, n).ToList();
        var result = DFS(players, firstPlayer, secondPlayer, 1);
        return new int[] { result.Item1, result.Item2 };
    }

    private (int, int) DFS(List<int> players, int firstPlayer, int secondPlayer, int round)
    {
        string key = string.Join(",", players) + "|" + round;
        if (memo.ContainsKey(key))
            return memo[key];

        int idx1 = players.IndexOf(firstPlayer);
        int idx2 = players.IndexOf(secondPlayer);

        if (idx1 + idx2 == players.Count - 1) // They face each other
            return (round, round);

        int minRound = int.MaxValue;
        int maxRound = int.MinValue;

        List<(int, int)> pairs = new List<(int, int)>();
        int len = players.Count;
        for (int i = 0; i < len / 2; i++)
            pairs.Add((players[i], players[len - 1 - i]));

        List<int> middle = (len % 2 == 1) ? new List<int> { players[len / 2] } : new List<int>();

        void Backtrack(int index, List<int> winners)
        {
            if (index == pairs.Count)
            {
                var nextPlayers = winners.Concat(middle).OrderBy(x => x).ToList();
                var result = DFS(nextPlayers, firstPlayer, secondPlayer, round + 1);
                minRound = Math.Min(minRound, result.Item1);
                maxRound = Math.Max(maxRound, result.Item2);
                return;
            }

            int a = pairs[index].Item1;
            int b = pairs[index].Item2;

            if (a == firstPlayer || b == firstPlayer || a == secondPlayer || b == secondPlayer)
            {
                if (a == firstPlayer || b == firstPlayer)
                    Backtrack(index + 1, new List<int>(winners) { firstPlayer });
                else
                    Backtrack(index + 1, new List<int>(winners) { secondPlayer });
            }
            else
            {
                Backtrack(index + 1, new List<int>(winners) { a });
                Backtrack(index + 1, new List<int>(winners) { b });
            }
        }

        Backtrack(0, new List<int>());

        var resultPair = (minRound, maxRound);
        memo[key] = resultPair;
        return resultPair;
    }
}