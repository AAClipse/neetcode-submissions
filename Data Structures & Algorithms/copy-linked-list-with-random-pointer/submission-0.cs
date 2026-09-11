/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) return null;

        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();

        Node current = head;
        while (current != null) {
            oldToNew[current] = new Node(current.val);
            current = current.next;
        }

        current = head;
        while (current != null) {
            Node clone = oldToNew[current];
            clone.next = current.next != null ? oldToNew[current.next] : null;
            clone.random = current.random != null ? oldToNew[current.random] : null;
            
            current = current.next;
        }

        return oldToNew[head];
    }
}
