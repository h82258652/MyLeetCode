using System.Linq;

namespace LeetCode905
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            return nums.OrderBy(temp => temp % 2 != 0).ToArray();
        }
    }
}
