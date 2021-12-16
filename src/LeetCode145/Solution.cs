using System.Collections.Generic;

namespace LeetCode145
{
    public class Solution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            InternalPostorderTraversal(root, list);
            return list;
        }

        private void InternalPostorderTraversal(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            InternalPostorderTraversal(node.left, list);
            InternalPostorderTraversal(node.right, list);
            list.Add(node.val);
        }
    }
}
