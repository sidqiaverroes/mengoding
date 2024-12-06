//leetcode 876: Middle of the Linked List

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
    public ListNode MiddleNode(ListNode head) {
        ListNode current = head;
        int count = 0;

        //Counting the list length
        while(current != null)
        {
            current = current.next;
            count++;
        }

        for(int i=0; i<count/2; i++)
        {
            head = head.next;
        }

        return head;
    }
}