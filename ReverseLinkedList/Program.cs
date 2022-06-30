

static ListNode ReverseNode(ListNode node)
{
    if (node == null) return null;
    if (node.next == null) return node;
    ListNode prev = node;
    ListNode cur = node.next;
    prev.next = null;
    do
    {
        ListNode temp = cur.next;
        cur.next = prev;
        prev = cur;
        cur = temp;
    }
    while (cur != null);
    return prev;
}

ListNode Head = null;
ListNode newHead = ReverseNode(Head);
while(newHead != null)
{
    Console.WriteLine(newHead.val);
    newHead = newHead.next;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}