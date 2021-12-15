namespace LeetCode231
{
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            // 如果 n 是 2 的幂，则 n 的二进制形式最左边第一位是 1，其余是 0
            // 而 n-1 的位全是 1
            return (n & (n - 1)) == 0 && n > 0;
        }
    }
}
