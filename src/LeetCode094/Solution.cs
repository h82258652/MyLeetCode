using System.Collections.Generic;

namespace LeetCode094
{
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            InternalInorderTraversal(root, list);
            return list;
        }

        private void InternalInorderTraversal(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            InternalInorderTraversal(node.left, list);
            list.Add(node.val);
            InternalInorderTraversal(node.right, list);
        }
    }
}
