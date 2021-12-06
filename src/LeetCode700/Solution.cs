namespace LeetCode700
{
    public class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (true)
            {
                if (root == null)
                {
                    return null;
                }

                if (root.val == val)
                {
                    return root;
                }

                root = val < root.val ? root.left : root.right;
            }
        }
    }
}
