namespace LeetCode088
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var num1Point = m - 1;// nums1 最后一个元素的位置
            var num2Point = n - 1;// nums2 最后一个元素的位置
            var resultPoint = m + n - 1;// 最终结果的最后一个元素的位置

            while (num1Point >= 0 && num2Point >= 0)
            {
                var num1 = nums1[num1Point];
                var num2 = nums2[num2Point];
                if (num1 <= num2)
                {
                    // 如果 num2 的值大于等于 num1 的值，则将 num2 的值放到结果数组指针的位置，并将 nums2 指针和结果数组指针往前移动
                    nums1[resultPoint] = num2;
                    num2Point--;
                    resultPoint--;
                }
                else
                {
                    // 如果 num1 的值大于 num2 的值，则将 num1 的这个值放到结果数组指针的位置，并将 nums1 指针和结果数组指针往前移动
                    nums1[resultPoint] = num1;
                    num1Point--;
                    resultPoint--;
                }
            }

            // 如果 nums2 的指针大于等于 0，说明 nums2 还有剩余元素没复制到结果数组中
            while (num2Point >= 0)
            {
                nums1[resultPoint] = nums2[num2Point];
                num2Point--;
                resultPoint--;
            }
        }
    }
}
