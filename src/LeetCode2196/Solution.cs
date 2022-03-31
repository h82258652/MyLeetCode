using System.Collections.Generic;
using System.Linq;

namespace LeetCode2196
{
    public class Solution
    {
        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            var nodes = new Dictionary<int, TreeNode>();
            var parents = new HashSet<TreeNode>();

            foreach (var description in descriptions)
            {
                var parentValue = description[0];
                var childValue = description[1];
                var isLeft = description[2] == 1;

                if (!nodes.TryGetValue(parentValue, out var parent))
                {
                    parent = new TreeNode(parentValue);
                    nodes[parentValue] = parent;
                    parents.Add(parent);
                }

                if (!nodes.TryGetValue(childValue, out var child))
                {
                    child = new TreeNode(childValue);
                    nodes[childValue] = child;
                }

                parents.Remove(child);

                if (isLeft)
                {
                    parent.left = child;
                }
                else
                {
                    parent.right = child;
                }
            }

            return parents.Single();
        }
    }
}
