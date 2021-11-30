using System.Linq;

namespace LeetCode169
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            return nums.GroupBy(temp => temp).OrderByDescending(temp => temp.Count()).First().Key;
        }
    }
}
