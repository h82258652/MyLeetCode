namespace LeetCode035
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            return SearchInsert(nums, target, 0, nums.Length - 1);
        }

        private int SearchInsert(int[] nums, int target, int low, int high)
        {
            if (high - low <= 1)
            {
                var highValue = nums[high];
                if (highValue == target)
                {
                    return high;
                }

                var lowValue = nums[low];
                if (lowValue == target)
                {
                    return low;
                }

                if (target > highValue)
                {
                    return high + 1;
                }

                return target > lowValue ? high : low;
            }

            var midIndex = (low + high) / 2;
            var midValue = nums[midIndex];
            if (midValue == target)
            {
                return midIndex;
            }

            if (midValue < target)
            {
                return SearchInsert(nums, target, midIndex, high);
            }
            else
            {
                return SearchInsert(nums, target, low, midIndex);
            }
        }
    }
}
