public class LinkedListNode
{
    public int val { get; set; }
    public LinkedListNode next;
    public LinkedListNode(int val=0,LinkedListNode next=null) { 
        this.val = val;
        this.next = next;
    }
}

public class MyLinkedList {
    
    public LinkedListNode Head { get; set; }
    public int Size { get; set; }
        
    public MyLinkedList() {
        
    }
    
    public int Get(int index)
    {
        if (index >= Size)
        {
            return -1;
        }

        LinkedListNode current = Head;
        int i = 0;
        while (i != index)
        {
            current = current.next; 
            i++;
        }

        return current.val;
    }

    public void AddAtHead(int val)
    {
        if (Head == null)
        {
            Head = new LinkedListNode(val);
            Size = 1;
        }
        else
        {
            LinkedListNode newNode = new LinkedListNode(val);
            newNode.next = Head;
            Head = newNode;
            Size++;
        }
    }

    public void AddAtTail(int val)
    {
        if (Head == null)
        {
            AddAtHead(val);
            return;
        }
        LinkedListNode current = Head;
        while (current.next != null)
        {
            current = current.next;
        }
        current.next = new LinkedListNode(val);
        Size++;
    }

    public void AddAtIndex(int index, int val)
    {
        LinkedListNode newNode = new LinkedListNode(val);
        if (index == 0)
        {
            newNode.next = Head;
            Head = newNode;
            Size++;
            return;
        }
        
        if (index > Size)
        {
            return;
        }

        LinkedListNode current = Head;
        int i = 0;
        while (i != index-1)
        {
            current = current.next;
            i++;
        }

        newNode.next = current.next;
        current.next = newNode;
        Size++;
    }

    public void DeleteAtIndex(int index)
    {
        if (Size == 0)
        {
            return;
        }

        if (index < Size && index >= 0 )
        {
            if (index == 0)
            {
                Head = Head.next;
                Size--;
            }
            else
            {
                LinkedListNode current = Head;
                int i = 0;
                while(i != index-1)
                {
                    current = current.next;
                    i++;
                }
                current.next = current.next.next;
                Size--;
            }
        }
    }
}