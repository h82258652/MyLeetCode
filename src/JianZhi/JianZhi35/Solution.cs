using System.Collections.Generic;

namespace JianZhi35
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)
        /// 空间复杂度 O(n)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node CopyRandomList(Node head)
        {
            var node = head;
            Node copyHead = null;
            Node copyNode = null;
            var originalToCopyMap = new Dictionary<Node, Node>();// 原始节点和复制节点的映射

            // 第一遍先复制节点和设置next
            while (node != null)
            {
                var temp = new Node(node.val);
                if (copyNode != null)
                {
                    copyNode.next = temp;
                }

                copyNode = temp;
                originalToCopyMap[node] = copyNode;

                if (copyHead == null)
                {
                    copyHead = copyNode;
                }

                node = node.next;
            }

            node = head;
            copyNode = copyHead;

            // 第二遍设置random
            while (node != null && copyNode != null)
            {
                if (node.random != null)
                {
                    copyNode.random = originalToCopyMap[node.random];
                }

                node = node.next;
                copyNode = copyNode.next;
            }

            return copyHead;
        }
    }
}
