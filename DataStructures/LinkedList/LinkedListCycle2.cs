/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class LinkedListCycle2 {
    public ListNode DetectCycle(ListNode head) {
        ListNode slowRunner = head;
        ListNode fastRunner = head;
        
        while (fastRunner != null && fastRunner.next != null){
            slowRunner = slowRunner.next;
            fastRunner = fastRunner.next.next;
            
            if (fastRunner == slowRunner)
                break;
        }

        if (fastRunner == null || fastRunner.next == null) {
            return null;
        }

        while (head != slowRunner){
            head = head.next;
            slowRunner = slowRunner.next;
        }
        
        return head;
    }
}