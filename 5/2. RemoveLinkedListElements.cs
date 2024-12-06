//leetcode 203: Remove Linked List Elements

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
    public ListNode RemoveElements(ListNode head, int val) {
        //My origin solution
        if(head == null) return head;

        ListNode node = null; //prev node
        ListNode current = head; //current node

        while(current != null)
        {
            if(current.val == val)
            {
                //do deletion
                if(node == null)
                {
                    head = current.next; //when the first node
                }
                else
                {
                    node.next = current.next;
                    current = node;
                }
            }
            else
            {
                node = current;
            }
            current = current.next;
            
        }

        return head;
    }
}