namespace LeetCode019
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var length = 0;
            var node = head;
            while (node != null)
            {
                length++;
                node = node.next;
            }

            if (length == n)
            {
                return head.next;
            }

            node = head;
            var move = length - n;
            while (move > 1)
            {
                node = node.next;
                move--;
            }

            node.next = node.next.next;

            return head;
        }
    }
}
