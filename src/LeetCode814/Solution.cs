using System.Collections.Generic;

namespace LeetCode814
{
    public class Solution
    {
        public TreeNode PruneTree(TreeNode root)
        {
            var dict = new Dictionary<TreeNode, bool>();
            PostOrder(root, dict);

            return dict[root] ? null : root;
        }

        private void PostOrder(TreeNode node, Dictionary<TreeNode, bool> canDeleteDict)
        {
            if (node == null)
            {
                return;
            }

            if (node.left != null)
            {
                PostOrder(node.left, canDeleteDict);
                if (canDeleteDict[node.left])
                {
                    node.left = null;
                }
            }

            if (node.right != null)
            {
                PostOrder(node.right, canDeleteDict);
                if (canDeleteDict[node.right])
                {
                    node.right = null;
                }
            }

            canDeleteDict[node] = node.val == 0 && node.left == null && node.right == null;
        }
    }
}
