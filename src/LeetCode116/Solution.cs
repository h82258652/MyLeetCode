using System.Collections.Generic;

namespace LeetCode116
{
    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }

            var queue = new Queue<Node>();
            var index = 1;
            queue.Enqueue(root);
            Node previous = null;
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                // 将前一个的 next 指向当前节点
                if (previous != null)
                {
                    previous.next = node;
                }

                previous = !IsLineLastIndex(index) ? node : null;

                index++;
            }

            return root;
        }

        /// <summary>
        /// 当前序号是不是这一层的最后一个
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool IsLineLastIndex(int index)
        {
            index++;
            return (index & (index - 1)) == 0 && index > 0;
        }
    }
}
