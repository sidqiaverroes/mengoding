//2. Add Two Numbers
//26 June 2025

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode root = new ListNode();
        ListNode curr = root;
        int hold = 0;

        while (l1 != null || l2 != null)
        {
            int val1 = l1 == null ? 0 : l1.val;
            int val2 = l2 == null ? 0 : l2.val;
            int sum = val1 + val2 + hold;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            hold = sum / 10;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (hold != 0)
        {
            curr.next = new ListNode(hold);
        }

        return root.next;
    }
}