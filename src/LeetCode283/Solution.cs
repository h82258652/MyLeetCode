namespace LeetCode283
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            var length = nums.Length;

            for (var i = 0; i < length; i++)
            {
                var num = nums[i];
                if (num != 0)
                {
                    continue;
                }

                for (var j = i + 1; j < length; j++)
                {
                    var otherNum = nums[j];
                    if (otherNum == 0)
                    {
                        continue;
                    }

                    nums[i] = otherNum;
                    nums[j] = num;
                    break;
                }
            }
        }
    }
}
