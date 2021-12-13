namespace LeetCode1791
{
    public class Solution
    {
        public int FindCenter(int[][] edges)
        {
            var edge00 = edges[0][0];
            if (edge00 == edges[1][0])
            {
                return edge00;
            }

            if (edge00 == edges[1][1])
            {
                return edge00;
            }

            return edges[0][1];
        }
    }
}
