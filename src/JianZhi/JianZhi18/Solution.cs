namespace JianZhi18
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，n为链表长度
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode DeleteNode(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }

            // 如果第一个节点是目标，则直接返回next
            if (head.val == val)
            {
                return head.next;
            }

            var previous = head;
            var node = head;
            while (node != null)
            {
                if (node.val == val)
                {
                    previous.next = node.next;
                    break;
                }

                previous = node;
                node = node.next;
            }

            return head;
        }
    }
}
