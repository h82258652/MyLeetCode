namespace LeetCode461
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            var xor = x ^ y;
            var result = 0;
            while (xor > 0)
            {
                if (xor % 2 == 1)
                {
                    result++;
                }

                xor >>= 1;
            }

            return result;
        }
    }
}
