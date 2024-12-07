//leetcode 160: Intersection of Two Linked Lists

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        //My origin solution, slow tho
        ListNode head = headA;
        if(headA == headB) return (headA);

        while(headB != null)
        {
            while(headA != null)
            {
                if(headA == headB)
                {
                    return headA;
                }
                else
                {
                    headA = headA.next;
                }
            }
            headB = headB.next;
            headA = head;
        }

        return null;

        //another approach
        //damn, its based on 2 + 3 = 3 + 2, so the time complexity will be O(n+m)
        ListNode a = headA;
        ListNode b = headB;
        while(a != b)
        {
            if(a == null) a = headB;
            else a = a.next;

            if(b == null) b = headA;
            else b = b.next;
        }

        return a;
    }
}