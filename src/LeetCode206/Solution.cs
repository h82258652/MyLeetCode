namespace LeetCode206
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            var node = head;
            ListNode previous = null;
            while (node != null)
            {
                var next = node.next;
                node.next = previous;
                previous = node;
                node = next;
            }

            return previous;
        }
    }
}
