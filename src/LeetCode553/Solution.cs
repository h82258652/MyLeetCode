using System.Text;

namespace LeetCode553
{
    public class Solution
    {
        public string OptimalDivision(int[] nums)
        {
            var length = nums.Length;
            if (length == 1)
            {
                return nums[0].ToString();
            }

            if (length == 2)
            {
                return nums[0] + "/" + nums[1];
            }

            var builder = new StringBuilder();
            builder.Append(nums[0]);
            builder.Append("/(");
            for (var i = 1; i < length; i++)
            {
                builder.Append(nums[i]);
                if (i != length - 1)
                {
                    builder.Append('/');
                }
            }

            builder.Append(')');
            return builder.ToString();
        }
    }
}
