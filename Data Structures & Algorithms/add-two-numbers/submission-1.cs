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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var dummy = new ListNode(0, null);
        var memory = dummy;
        int remain = 0;
        int sum = 0;
        while (l1 != null || l2 != null || remain > 0){
            if (l1 != null && l2 != null) sum = l1.val + l2.val + remain;
            else if (l1 == null && l2 != null) sum = l2.val + remain;
            else if (l1 != null && l2 == null) sum = l1.val + remain;
            else sum = remain;

            int first = sum % 10;
            remain = sum / 10;
            var node = new ListNode(first);
            dummy.next = node;
            dummy = dummy.next;
            if (l1 != null && l2 != null) {
                l1 = l1.next;
                l2 = l2.next;   
            }
            else if (l1 == null && l2 != null) l2 = l2.next;
            else if (l1 != null && l2 == null)  l1 = l1.next;
            else break;
        }
        return memory.next;
    }
}
