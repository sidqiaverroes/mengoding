//leetcode 234: Palindrome Linked List

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
    public bool IsPalindrome(ListNode head) {
        //My origin solution: combining middlenode and reverse function
        ListNode first = head;
        ListNode last = head;

        //Go to the middle Node and reverse
        last = MiddleNode(last);
        last = ReverseList(last);

        while(last != null && first != null)
        {
            if(first.val == last.val)
            {
                first = first.next;
                last = last.next;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

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

    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;

        while(current != null)
        {
            ListNode nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;
        }

        return prev;
    }
}