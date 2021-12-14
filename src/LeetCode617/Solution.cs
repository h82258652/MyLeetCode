namespace LeetCode617
{
    public class Solution
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return null;
            }

            if (root1 == null)
            {
                var node = new TreeNode(root2.val)
                {
                    left = MergeTrees(null, root2.left),
                    right = MergeTrees(null, root2.right)
                };
                return node;
            }

            if (root2 == null)
            {
                var node = new TreeNode(root1.val)
                {
                    left = MergeTrees(null, root1.left),
                    right = MergeTrees(null, root1.right)
                };
                return node;
            }

            {
                var node = new TreeNode(root1.val + root2.val)
                {
                    left = MergeTrees(root1.left, root2.left),
                    right = MergeTrees(root1.right, root2.right)
                };
                return node;
            }
        }
    }
}
