namespace JianZhi10
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib(int n)
        {
            if (n <= 1)// Fib(0)=0，Fib(1)=1
            {
                return n;
            }

            var minus2 = 0;// Fib(n-2)
            var minus1 = 1;// Fib(n-1)
            for (var i = 2; i <= n; i++)
            {
                var current = minus1 + minus2;// Fib(n)
                current %= 1000000007;// 题目需要取模
                minus2 = minus1;
                minus1 = current;
            }

            return minus1;
        }
    }
}
