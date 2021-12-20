namespace JianZhi27
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，n为节点个数
        /// 空间复杂度 O(logn)，为递归堆栈空间
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode MirrorTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            (root.left, root.right) = (root.right, root.left);
            MirrorTree(root.left);
            MirrorTree(root.right);
            return root;
        }
    }
}
