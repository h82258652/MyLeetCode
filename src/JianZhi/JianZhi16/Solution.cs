namespace JianZhi16
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(logn)
        /// 空间复杂度 O(logn)，递归堆栈
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double MyPow(double x, int n)
        {
            if (x == 0)
            {
                return 0;
            }

            if (n == 0)
            {
                return 1;
            }

            if (n == 1)
            {
                return x;
            }

            if (n == -1)
            {
                return 1 / x;
            }

            if (n > 0)
            {
                if ((n & 1) == 0)
                {
                    return MyPow(x * x, n >> 1);// 如果 n 是偶数，x^n=(x*x)^(n/2)
                }
                else
                {
                    return MyPow(x * x, n >> 1) * x;// 如果 n 是奇数，x^n=(x*x)^(n/2)*x
                }
            }
            else
            {
                // 注意负数除2和右移1效果不一样

                if ((n & 1) == 0)
                {
                    return MyPow(x * x, n / 2);// 如果 n 是偶数，x^(-n)=(x*x)^((-n)/2)
                }
                else
                {
                    // 如果 n 是奇数，x^(-n)=(x*x)^((-n)/2-1)*x;
                    // 例如 x=2，n=-3
                    // 2^(-3)=4^(-2)*2
                    return MyPow(x * x, n / 2 - 1) * x;
                }
            }
        }
    }
}
