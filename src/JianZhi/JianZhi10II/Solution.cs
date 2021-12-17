namespace JianZhi10II
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumWays(int n)
        {
            // n==0, 1
            // n==1, 1
            if (n <= 1)
            {
                return 1;
            }

            var minus2 = 1;// n=1时
            var minus1 = 2;// n=2时
            for (var i = 3; i <= n; i++)
            {
                var current = minus1 + minus2;
                current %= 1000000007;// 题目需要取模
                minus2 = minus1;
                minus1 = current;
            }

            return minus1;
        }
    }
}
