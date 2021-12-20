namespace JianZhi21
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] Exchange(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left < right)
            {
                var leftVal = nums[left];
                if ((leftVal & 1) == 1)// leftVal%2==1
                {
                    left++;
                    continue;
                }

                var rightVal = nums[right];
                if ((rightVal & 1) == 0)// rightVal%2==0
                {
                    right--;
                    continue;
                }

                nums[left] = rightVal;
                nums[right] = leftVal;
                left++;
                right--;
            }

            return nums;
        }
    }
}
