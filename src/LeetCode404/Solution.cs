namespace LeetCode404
{
    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            return SumOfLeftLeaves(root, false);
        }

        private int SumOfLeftLeaves(TreeNode node, bool isLeft)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.left == null && node.right == null) // 是叶子节点
            {
                if (isLeft)
                {
                    // 是左叶子节点
                    return node.val;
                }
                else
                {
                    // 是右叶子节点
                    return 0;
                }
            }

            // 不是叶子节点

            var leftSum = SumOfLeftLeaves(node.left, true);
            var rightSum = SumOfLeftLeaves(node.right, false);
            return leftSum + rightSum;
        }
    }
}
