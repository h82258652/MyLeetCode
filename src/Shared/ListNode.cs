using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public int[] ToArray()
    {
        var array = new List<int>();
        var node = this;
        while (node != null)
        {
            array.Add(node.val);
            node = node.next;
        }

        return array.ToArray();
    }

    public static ListNode Create(int[] array)
    {
        ListNode root = null;
        ListNode node = null;
        foreach (var i in array)
        {
            if (root == null)
            {
                root = new ListNode(i);
                node = root;
            }
            else
            {
                node.next = new ListNode(i);
                node = node.next;
            }
        }

        return root;
    }
}
