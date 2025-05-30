//2359. Find Closest Node to Given Two Nodes
//30 May 2025

public class Solution {
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        bool[] visitedFromNode1 = new bool[edges.Length];
        bool[] visitedFromNode2 = new bool[edges.Length];

        int currentNode1 = node1, currentNode2 = node2;
        int foundFromNode1 = -1, foundFromNode2 = -1;

        while((currentNode1 != -1 || currentNode2 != -1) && (foundFromNode1 == -1 && foundFromNode2 == -1))
        {
            if(currentNode1 == -1 || visitedFromNode1[currentNode1]) // handling loop or end node
            {
                currentNode1 = -1;
            }
            else
            {
                visitedFromNode1[currentNode1] = true;

                if(visitedFromNode2[currentNode1])
                {
                    foundFromNode1 = currentNode1;
                    currentNode1 = -1;
                }
                else
                {
                    currentNode1 = edges[currentNode1];
                }
            }

            if(currentNode2 == -1 || visitedFromNode2[currentNode2]) // handling loop or end node
            {
                currentNode2 = -1;
            }
            else
            {
                visitedFromNode2[currentNode2] = true;

                if(visitedFromNode1[currentNode2])
                {
                    foundFromNode2 = currentNode2;
                    currentNode2 = -1;
                }
                else
                {
                    currentNode2 = edges[currentNode2];
                }
            }
        }

        return foundFromNode1 == -1 ? foundFromNode2 
                    : (foundFromNode2 == -1 ? foundFromNode1 
                        : (Math.Min(foundFromNode1, foundFromNode2)));
    }
}