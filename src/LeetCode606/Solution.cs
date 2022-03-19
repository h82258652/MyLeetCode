using System.Text;

namespace LeetCode606
{
    public class Solution
    {
        public string Tree2str(TreeNode root)
        {
            var result = new StringBuilder();
            InternalTree2str(root, result);
            return result.ToString();
        }

        private void InternalTree2str(TreeNode node, StringBuilder builder)
        {
            if (node == null)
            {
                return;
            }

            builder.Append(node.val);
            if (node.left == null && node.right == null)
            {
                return;
            }

            if (node.left != null && node.right == null)
            {
                builder.Append('(');
                InternalTree2str(node.left, builder);
                builder.Append(')');
                return;
            }

            builder.Append('(');
            InternalTree2str(node.left, builder);
            builder.Append(")(");
            InternalTree2str(node.right, builder);
            builder.Append(')');
        }
    }
}
