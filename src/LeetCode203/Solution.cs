namespace LeetCode203
{
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }

            ListNode result = null;// 指向第一个不是 val 的节点

            ListNode prev = null;
            while (head != null)
            {
                if (head.val != val)
                {
                    if (result == null)
                    {
                        result = head;
                    }
                }
                else
                {
                    // 是 val 的时候，将前一个节点的 next 指向当前节点的下一个节点，相当于跳过当前节点
                    if (prev != null)
                    {
                        prev.next = head.next;

                        // 因为当前 head 是被删除的节点，所以 prev 还是指向前一个节点不用动，head 挪到下一个节点
                        head = head.next;
                        continue;
                    }
                }

                prev = head;
                head = head.next;
            }

            return result;
        }
    }
}
