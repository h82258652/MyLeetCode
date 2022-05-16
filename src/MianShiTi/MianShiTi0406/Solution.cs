using System.Collections.Generic;

namespace MianShiTi0406
{
    public class Solution
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            var list = new List<TreeNode>();
            Inorder(root, list);

            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] == p && i + 1 < list.Count)
                {
                    return list[i + 1];
                }
            }

            return null;
        }

        private void Inorder(TreeNode node, List<TreeNode> list)
        {
            if (node == null)
            {
                return;
            }

            Inorder(node.left, list);
            list.Add(node);
            Inorder(node.right, list);
        }
    }
}
