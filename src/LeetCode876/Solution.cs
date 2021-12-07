namespace LeetCode876
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var length = 0;// 节点数量
            var node = head;
            while (node != null)
            {
                length++;
                node = node.next;
            }

            // 因为已经在第一个节点的位置，所以对于偶数个节点的情况，从第一个节点移动 midLength 必然到达中间靠右的那个节点
            var midLength = length / 2;

            node = head;
            while (midLength > 0)
            {
                node = node.next;
                midLength--;
            }

            return node;
        }
    }
}
