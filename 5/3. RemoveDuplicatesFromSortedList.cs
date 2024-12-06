//leetcode 83: Remove Duplicates from Sorted List

//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        //My original solution
        HashSet<int> set = [];
        ListNode prev = null;
        ListNode current = head;

        while(current != null)
        {
            if(!set.Contains(current.val))
            {
                set.Add(current.val);
                //move next
                prev = current;
                current = current.next;
            }
            else
            {
                //do deletion
                prev.next = current.next;
                //move next
                current = current.next;
            }
        }

        return head;
    }
}