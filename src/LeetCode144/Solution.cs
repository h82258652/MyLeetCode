using System.Collections.Generic;

namespace LeetCode144
{
    public class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            PreorderTraversal(root, result);
            return result;
        }

        private void PreorderTraversal(TreeNode node, IList<int> list)
        {
            if (node == null)
            {
                return;
            }

            list.Add(node.val);
            PreorderTraversal(node.left, list);
            PreorderTraversal(node.right, list);
        }
    }
}
