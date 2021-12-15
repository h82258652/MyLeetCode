namespace LeetCode190
{
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            var result = 0u;
            for (var i = 0; i < 32; i++)
            {
                result <<= 1;
                result += n & 1;
                n >>= 1;
            }

            return result;
        }
    }
}
