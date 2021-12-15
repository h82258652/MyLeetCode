using System.Collections.Generic;

namespace LeetCode102
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            var result = new List<IList<int>>();

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var levelCount = queue.Count;

                var level = new List<int>();

                for (var i = 0; i < levelCount; i++)
                {
                    var node = queue.Dequeue();

                    level.Add(node.val);

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                result.Add(level);
            }

            return result;
        }
    }
}
