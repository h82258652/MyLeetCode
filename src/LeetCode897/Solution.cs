using System.Collections.Generic;

namespace LeetCode897
{
    public class Solution
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            var nodes = new List<TreeNode>();
            Inorder(root, nodes);

            var newRoot = nodes[0];

            for (var i = 1; i < nodes.Count; i++)
            {
                var parent = nodes[i - 1];
                parent.left = null;
                parent.right = nodes[i];

                if (i == nodes.Count - 1)
                {
                    nodes[i].left = null;
                    nodes[i].right = null;
                }
            }

            return newRoot;
        }

        private void Inorder(TreeNode node, List<TreeNode> nodes)
        {
            if (node == null)
            {
                return;
            }

            Inorder(node.left, nodes);
            nodes.Add(node);
            Inorder(node.right, nodes);
        }
    }
}
