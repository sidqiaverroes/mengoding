//21. Merge Two Sorted Lists
//22 May 2025

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        //My origin solution, idk is it efficient in space, but it works
        if (list1 == null && list2 != null) return list2;
        if (list2 == null && list1 != null) return list1;
        if (list1 == null && list2 == null) return null;

        // creating new linked list
        ListNode head = null;
        ListNode prev = null;
        ListNode current = null;
        ListNode current2 = null;

        //set head
        if (list1.val <= list2.val)
        {
            head = list1;
            current = list1.next;
            prev = list1;
            current2 = list2;
        }
        else
        {
            head = list2;
            current = list2.next;
            prev = list2;
            current2 = list1;
        }

        while (current != null && current2 != null)
        {

            if (current.val >= current2.val)
            {
                prev.next = current2;
                prev = current2;
                current2 = current2.next;
            }
            else
            {
                prev.next = current;
                prev = current;
                current = current.next;
            }
        }

        if (current == null)
        {
            prev.next = current2;
        }
        else if (current2 == null)
        {
            prev.next = current;
        }

        return head;
    }
}