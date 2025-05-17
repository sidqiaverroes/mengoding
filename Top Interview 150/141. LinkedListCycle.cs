//141. Linked List Cycle
//17 May 2025

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        //My original solution
        HashSet<ListNode> map = [];

        while(!map.Contains(head))
        {
            if(head == null) return false;
            map.Add(head);
            head = head.next;
        }

        return true;
    }
}