namespace JianZhi15
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，n为输入的二进制的位数
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HammingWeight(uint n)
        {
            var result = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)// n%2==1
                {
                    result++;
                }

                n >>= 1;// n=n/2
            }

            return result;
        }
    }
}
