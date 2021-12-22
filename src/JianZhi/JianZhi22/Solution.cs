namespace JianZhi22
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，n为链表长度
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            var length = 0;
            var node = head;
            while (node != null)
            {
                length++;
                node = node.next;
            }

            length -= k;
            node = head;
            while (length > 0)
            {
                node = node.next;
                length--;
            }

            return node;
        }
    }
}
