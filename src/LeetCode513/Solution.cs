using System.Collections.Generic;

namespace LeetCode513
{
    public class Solution
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            var nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            var result = 0;
            while (nodes.Count > 0)
            {
                var levelCount = nodes.Count;
                result = nodes.Peek().val;

                for (var i = 0; i < levelCount; i++)
                {
                    var node = nodes.Dequeue();
                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }
            }

            return result;
        }
    }
}
