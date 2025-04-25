public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class LinkedListCycle{
    public bool HasCycle(ListNode Head) {
        if (Head == null || Head.next == null)
            return false;

        ListNode turtle = Head;
        ListNode rabbit = Head.next;

        while (turtle.next != null && rabbit.next != null)
        {
            if (rabbit == turtle)
            {
                return true;
            }
            if (turtle.next == null || rabbit.next.next == null)
            {
                return false;
            }
            rabbit = rabbit.next.next;
            turtle = turtle.next;
        }
        return false;
    }
}