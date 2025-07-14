//1290. Convert Binary Number in a Linked List to Integer
//14 July 2025

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        int res = 0;

        while (head != null)
        {
            res <<= 1;
            res |= head.val;
            head = head.next;
        }

        return res;
    }
}