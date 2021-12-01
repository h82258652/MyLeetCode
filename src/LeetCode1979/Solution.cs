namespace LeetCode1979
{
    public class Solution
    {
        public int FindGCD(int[] nums)
        {
            var min = nums[0];
            var max = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                var num = nums[i];
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }

            return GetGCD(max, min);
        }

        private int GetGCD(int max, int min)
        {
            if (max % min == 0)
            {
                return min;
            }

            var temp = min - 1;
            while (temp > 0)
            {
                if (min % temp == 0 && max % temp == 0)
                {
                    return temp;
                }

                temp--;
            }

            return 1;
        }
    }
}
