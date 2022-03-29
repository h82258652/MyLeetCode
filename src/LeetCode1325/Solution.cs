namespace LeetCode1325
{
    public class Solution
    {
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            return PostOrder(root, target) ? null : root;
        }

        private bool PostOrder(TreeNode node, int target)
        {
            if (node == null)
            {
                return true;
            }

            if (node.left == null && node.right == null)
            {
                return node.val == target;
            }

            var removeLeft = PostOrder(node.left, target);
            if (removeLeft)
            {
                node.left = null;
            }

            var removeRight = PostOrder(node.right, target);
            if (removeRight)
            {
                node.right = null;
            }

            return removeLeft && removeRight && node.val == target;
        }
    }
}
