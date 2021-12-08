namespace LeetCode413
{
    public class Solution
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            var length = nums.Length;
            if (length <= 2)
            {
                return 0;
            }

            var result = 0;

            var currentDivCount = 0;
            var div = nums[1] - nums[0];
            for (var i = 2; i < length; i++)
            {
                var currentDiv = nums[i] - nums[i - 1];
                if (currentDiv != div)
                {
                    currentDivCount = 0;
                    div = currentDiv;
                }
                else
                {
                    currentDivCount++;
                    result += currentDivCount;
                }
            }

            return result;
        }
    }
}
