namespace LeetCode2139
{
    public class Solution
    {
        public int MinMoves(int target, int maxDoubles)
        {
            var count = 0;
            while (target > 1)
            {
                if (maxDoubles > 0)
                {
                    if ((target & 1) == 0)
                    {
                        target >>= 1;
                        maxDoubles--;
                    }
                    else
                    {
                        target--;
                    }

                    count++;
                }
                else
                {
                    return target + count - 1;
                }
            }

            return count;
        }
    }
}
