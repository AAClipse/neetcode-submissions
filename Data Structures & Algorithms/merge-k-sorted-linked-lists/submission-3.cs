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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;
        
        int end = lists.Length - 1;
        
        // divide and conquer mega imba, 90 -> 80
        while (end > 0) {
            int start = 0;
            while (start < end) {
                lists[start] = Merger(lists[start], lists[end]);
                start++;
                end--;
            }
        }
        
        return lists[0];
    }
    public static ListNode Merger(ListNode list1, ListNode list2){
        ListNode dummy = new ListNode(0);
        ListNode prev = dummy;
        while (list1 != null && list2 != null){
            if (list1.val <= list2.val){
                prev.next = list1;
                list1 = list1.next;
            }
            else{
                prev.next = list2;
                list2 = list2.next;
            }
            prev = prev.next;
        }
        if (list1 == null) prev.next = list2;
        else if (list2 == null) prev.next = list1;
        return dummy.next;
    }
    
}
