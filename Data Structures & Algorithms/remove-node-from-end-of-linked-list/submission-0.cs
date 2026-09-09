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

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0, head);
        
        int length = 0;
        ListNode current = head;
        while (current != null) {
            length++;
            current = current.next;
        }
        
        int stepsToBefore = length - n;
        
        current = dummy;
        for (int i = 0; i < stepsToBefore; i++) {
            current = current.next;
        }
        
        current.next = current.next.next;
        
        return dummy.next;
    }
}
