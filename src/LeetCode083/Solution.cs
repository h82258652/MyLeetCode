namespace LeetCode083
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode result = head;

            ListNode prev = null;
            int previousValue = int.MinValue;

            while (head != null)
            {
                var value = head.val;
                if (previousValue != value)
                {
                    previousValue = value;
                    prev = head;
                    head = head.next;
                    continue;
                }

                prev!.next = head.next;
                head = head.next;
            }

            return result;
        }
    }
}
