namespace LeetCode141
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            var slow = head;
            var fast = head.next;

            while (fast != null)
            {
                if (slow == fast)
                {
                    return true;
                }

                slow = slow.next;
                fast = fast.next?.next;
            }

            return false;
        }
    }
}
