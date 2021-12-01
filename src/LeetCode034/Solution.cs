namespace LeetCode034
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var length = nums.Length;
            var result = InternalSearch(nums, target);
            if (result == -1)
            {
                return new[] { -1, -1 };
            }

            var first = result;
            while (first > 0)
            {
                if (nums[first - 1] == target)
                {
                    first--;
                }
                else
                {
                    break;
                }
            }

            var last = result;
            while (last < length - 1)
            {
                if (nums[last + 1] == target)
                {
                    last++;
                }
                else
                {
                    break;
                }
            }

            return new[] { first, last };
        }

        private int InternalSearch(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                var midIndex = (low + high) / 2;
                var midValue = nums[midIndex];
                if (midValue == target)
                {
                    return midIndex;
                }

                if (midValue < target)
                {
                    low = midIndex + 1;
                }
                else
                {
                    high = midIndex - 1;
                }
            }

            return -1;
        }
    }
}
