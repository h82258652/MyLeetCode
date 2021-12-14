namespace LeetCode278
{
    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                var mid = left + (right - left) / 2;// 防止 left + right 溢出
                var isBadVersion = IsBadVersion(mid);
                if (isBadVersion)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if (!IsBadVersion(left))
            {
                left++;
            }

            return left;
        }
    }
}
