namespace LeetCode938
{
    public class Solution
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }

            var val = root.val;
            var sum = 0;
            if (val < low)
            {
                sum += RangeSumBST(root.right, low, high);
            }
            else if (val > high)
            {
                sum += RangeSumBST(root.left, low, high);
            }
            else
            {
                sum += val;
                sum += RangeSumBST(root.left, low, high);
                sum += RangeSumBST(root.right, low, high);
            }

            return sum;
        }
    }
}
