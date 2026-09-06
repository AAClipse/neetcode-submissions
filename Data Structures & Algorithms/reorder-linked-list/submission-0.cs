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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        ListNode current = slow.next;
        slow.next = null;
        ListNode prev = null;
        while (current != null){
            ListNode nxt = current.next;
            current.next = prev;
            prev = current;
            current = nxt;
        }

        ListNode first = head;
        ListNode second = prev;

        while (second != null){
            ListNode tmp1 = first.next;
            ListNode tmp2 = second.next;

            first.next = second;
            second.next = tmp1;
            first = tmp1;
            second = tmp2;
        }
    }
}
