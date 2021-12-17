namespace JianZhi06
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，第一次遍历链表获取长度 n，第二次遍历链表获取值 n，合计 2n，忽略常数为 O(n)
        /// 空间复杂度 O(n)，为返回数组空间
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int[] ReversePrint(ListNode head)
        {
            // 先获取链表的长度
            var length = 0;
            var node = head;
            while (node != null)
            {
                length++;
                node = node.next;
            }

            // 从后往前填充数组
            var result = new int[length];
            node = head;
            while (node != null)
            {
                length--;
                result[length] = node.val;
                node = node.next;
            }

            return result;
        }
    }
}
