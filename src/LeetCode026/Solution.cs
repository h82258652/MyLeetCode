namespace LeetCode026
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var previous = int.MinValue;
            var k = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (num == previous)
                {
                    continue;
                }

                nums[k] = num;
                k++;
                previous = num;
            }

            return k;
        }
    }
}
