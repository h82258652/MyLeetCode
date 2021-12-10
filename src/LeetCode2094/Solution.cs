using System.Collections.Generic;

namespace LeetCode2094
{
    public class Solution
    {
        public int[] FindEvenNumbers(int[] digits)
        {
            var nums = new int[10];
            foreach (var digit in digits)
            {
                nums[digit]++;
            }

            var result = new List<int>();

            for (var i = 1; i < 10; i++)
            {
                var iCount = nums[i];
                if (iCount <= 0)
                {
                    continue;
                }

                for (var j = 0; j < 10; j++)
                {
                    var jCount = nums[j];
                    if (jCount <= 0 ||
                        i == j && jCount <= 1)
                    {
                        continue;
                    }

                    for (var k = 0; k < 10; k += 2)
                    {
                        var kCount = nums[k];
                        if (kCount <= 0 ||
                            i == k && kCount <= 1 ||
                            j == k && kCount <= 1 ||
                            i == j && i == k && j == k && kCount <= 2)
                        {
                            continue;
                        }

                        result.Add(i * 100 + j * 10 + k);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
