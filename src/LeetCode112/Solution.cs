namespace LeetCode112
{
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            var isLeafNode = IsLeafNode(root);
            if (isLeafNode)
            {
                return targetSum == root.val;
            }

            return HasPathSum(root.left, targetSum - root.val) ||
                   HasPathSum(root.right, targetSum - root.val);
        }

        private bool IsLeafNode(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
    }
}
