using System;

namespace JianZhi07
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n²)，因为要从中序遍历查找前序遍历的第一个元素，也就是根节点，最坏情况就是在中序遍历的最后，
        /// 然后每一次递归减少一个长度，所以时间复杂度是 n+(n-1)+(n-2)……+2+1，也就是 O(n²)
        /// 空间复杂度 O(n)，TreeNode 个数，每次递归使用的是切片，不需要额外的空间复杂度
        /// </summary>
        /// <param name="preorder"></param>
        /// <param name="inorder"></param>
        /// <returns></returns>
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length != inorder.Length)
            {
                throw new InvalidOperationException("前序和中序数量不一致");
            }

            return InternalBuildTree(preorder, inorder);
        }

        private TreeNode InternalBuildTree(Span<int> preorder, Span<int> inorder)
        {
            if (preorder.Length <= 0)
            {
                // 没有节点
                return null;
            }

            // 前序遍历的第一个是根节点
            var rootVal = preorder[0];
            var root = new TreeNode(rootVal);

            // 查找根节点在中序遍历的位置
            var rootValIndexIninorder = inorder.IndexOf(rootVal);

            // 中序遍历根节点左边的为左子树的中序遍历，右边的为右子树的中序遍历
            var leftInorder = inorder.Slice(0, rootValIndexIninorder);
            var rightInorder = inorder.Slice(rootValIndexIninorder + 1);

            // 前序遍历中间是左子树的前序遍历，右边是右子树的前序遍历，而且子树的前序遍历长度和中序遍历长度一致
            var leftPreorder = preorder.Slice(1, leftInorder.Length);
            var rightPreorder = preorder.Slice(1 + leftPreorder.Length);

            root.left = InternalBuildTree(leftPreorder, leftInorder);
            root.right = InternalBuildTree(rightPreorder, rightInorder);

            return root;
        }
    }
}
