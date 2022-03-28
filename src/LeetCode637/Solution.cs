using System.Collections.Generic;

namespace LeetCode637
{
    public class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();
            var nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                var sum = 0d;
                var count = nodes.Count;
                for (var i = 0; i < count; i++)
                {
                    var node = nodes.Dequeue();
                    sum += node.val;

                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }

                result.Add(sum / count);
            }

            return result;
        }
    }
}
