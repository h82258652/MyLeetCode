using System;

namespace LeetCode167
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while (left < right)
            {
                var leftValue = numbers[left];
                var rightValue = numbers[right];
                var sum = leftValue + rightValue;
                if (sum == target)
                {
                    return new[] { left + 1, right + 1 };
                }

                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            throw new InvalidOperationException();
        }
    }
}
