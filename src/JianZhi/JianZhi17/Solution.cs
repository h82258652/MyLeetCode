using System.Linq;

namespace JianZhi17
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(10^n)
        /// 空间复杂度 O(1)，返回结果不算入空间复杂度
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] PrintNumbers(int n)
        {
            var count = Pow(10, n) - 1;
            return Enumerable.Range(1, count).ToArray();
        }

        private int Pow(int x, int y)
        {
            var result = 1;
            while (y > 0)
            {
                result *= x;
                y--;
            }

            return result;
        }
    }
}
