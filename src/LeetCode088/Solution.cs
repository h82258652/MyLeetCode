using System;

namespace LeetCode088
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = new int[m + n];
            int i = 0;
            int j = 0;
            int k = 0;
            while (true)
            {
                if (i >= m)
                {
                    break;
                }

                if (j >= n)
                {
                    break;
                }

                var num1 = nums1[i];
                var num2 = nums2[j];
                if (num1 < num2)
                {
                    result[k] = num1;
                    i++;
                    k++;
                }
                else
                {
                    result[k] = num2;
                    j++;
                    k++;
                }
            }

            if (i < m)
            {
                for (int temp = i; temp < m; temp++)
                {
                    result[k] = nums1[temp];
                    k++;
                }
            }

            if (j < n)
            {
                for (int temp = j; temp < n; temp++)
                {
                    result[k] = nums2[temp];
                    k++;
                }
            }

            Array.Copy(result, nums1, m + n);
        }
    }
}
