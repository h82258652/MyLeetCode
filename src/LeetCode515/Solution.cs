using System;
using System.Collections.Generic;

namespace LeetCode515
{
    public class Solution
    {
        public IList<int> LargestValues(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            var nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            var result = new List<int>();

            while (nodes.Count > 0)
            {
                var count = nodes.Count;
                var max = int.MinValue;
                for (var i = 0; i < count; i++)
                {
                    var node = nodes.Dequeue();
                    max = Math.Max(max, node.val);

                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }

                result.Add(max);
            }

            return result;
        }
    }
}
